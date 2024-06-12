using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace _20_Project_My_Secret_Folder
{
    public partial class FileManagerForm : Form
    {
        private readonly int ICON_INDEX_FOLDER = 6;
        private readonly int ICON_INDEX_FILE = 5;

        private string currentFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private bool isItemBeingDragged = false;
        private ListViewItem draggedItem = null;
        private Point dragStart;
        private int draggedItemIndex = -1;


        public FileManagerForm()
        {
            InitializeComponent();
        }

        private void FileManagerForm_Load(object sender, EventArgs e)
        {
            string outputFolderPath = Path.Combine(this.currentFolder, "secret");

            if (!Directory.Exists(outputFolderPath))
            {
                Directory.CreateDirectory(outputFolderPath);
            }

            this.currentFolder = outputFolderPath;
            textBoxFilePath.Text = outputFolderPath;
            LoadAllFilesAndDirectories();
        }

        private void LoadAllFilesAndDirectories()
        {
            try
            {
                FileAttributes fileAttributes = File.GetAttributes(this.currentFolder);
                if (CheckIfItemIsDirectory(fileAttributes))
                {
                    OpenDirectory();
                }
            }
            catch (Exception)
            {
                ShowInfoLabelError("Cannot load files and directories");
            }
        }

        private void OpenDirectory()
        {
            DirectoryInfo fileList = new DirectoryInfo(this.currentFolder);

            ListAllFiles(fileList);
            ListAllDirectories(fileList);
        }

        private void ListAllDirectories(DirectoryInfo fileList)
        {
            var dirs = fileList.GetDirectories();

            foreach (DirectoryInfo dir in dirs)
            {
                this.listViewFiles.Items.Add(dir.Name, ICON_INDEX_FOLDER);
            }
        }

        private void ListAllFiles(DirectoryInfo fileList)
        {
            this.listViewFiles.Items.Clear();

            var files = fileList.GetFiles();
            foreach (var file in files)
            {
                this.listViewFiles.Items.Add(file.Name, GetImageIndex(file.Extension));
            }
        }

        private static readonly Dictionary<string, int> iconIdByExtension = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase)
            {
                { ".pptx", 0 },
                { ".zip", 1 },
                { ".doc", 2 },
                { ".docx", 2 },
                { ".pdf", 3 },
                { ".mp3", 4 },
                { ".exe", 7 },
                { ".com", 7 },
                { ".png", 8 },
                { ".txt", 9 },
            };

        private int GetImageIndex(string extension)
        {

            if (iconIdByExtension.ContainsKey(extension))
            {
                return iconIdByExtension[extension];
            }

            return ICON_INDEX_FILE;
        }

        private bool CheckIfItemIsDirectory(FileAttributes fileAttributes)
            => fileAttributes.HasFlag(FileAttributes.Directory);

        private void ShowInfoLabelError(string message)
        {
            labelFileInfo.ForeColor = Color.Red;
            labelFileInfo.Text = message;
        }

        private void ShowInfoLabel(string message)
        {
            labelFileInfo.ForeColor = Color.Black;
            labelFileInfo.Text = message;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePath();
                LoadAllFilesAndDirectories();
                CleanFileInfo();
            }
            catch (Exception)
            {
            }
        }

        private void CleanFileInfo()
        {
            this.labelFileNameValue.Text = "--";
            //this.labelFileTypeValue.Text = "--";
        }

        private void UpdatePath()
        {
            string path = this.textBoxFilePath.Text;
            path = Path.GetDirectoryName(path);
            this.textBoxFilePath.Text = path;
            this.currentFolder = path;
        }

        private void buttonUploadFile_Click(object sender, EventArgs e)
        {
            using (var newFileForm = new UploadFileForm(this.currentFolder))
            {
                if (newFileForm.ShowDialog() == DialogResult.OK)
                {
                    SaveDragAndDroppedFile(newFileForm.DroppedFilePath);
                }
            }
        }

        private void SaveDragAndDroppedFile(string droppedFilePath)
        {
            string newFileName = Path.GetFileName(droppedFilePath);
            string newFilePath = Path.Combine(this.currentFolder, newFileName);

            try
            {
                File.Copy(droppedFilePath, newFilePath);
                LoadAllFilesAndDirectories();
                ShowInfoLabel("Successfully added new file");
            }
            catch (Exception ex)
            {
                ShowInfoLabelError("Error saving file: " + ex.Message);
            }

        }

        private void buttonCreateFolder_Click(object sender, EventArgs e)
        {
            using (var newFolderForm = new NewFolderForm(this.currentFolder))
            {
                if (newFolderForm.ShowDialog() == DialogResult.OK)
                {
                    CreateNewFolder(newFolderForm.FolderName);
                }
            }

        }

        private void CreateNewFolder(string folderName)
        {
            string newFolderPath = Path.Combine(this.currentFolder, folderName);

            try
            {
                Directory.CreateDirectory(newFolderPath);

                LoadAllFilesAndDirectories();
                ShowInfoLabel("Sucessfully create folder");

            }
            catch (Exception ex)
            {
                ShowInfoLabelError("An error ouccured while creating the folder: " + ex.Message);
            }
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            using (var newTextFileForm = new NewTextFileForm(this.currentFolder))
            {
                if (newTextFileForm.ShowDialog() == DialogResult.OK)
                {
                    CreateNewTextFile(newTextFileForm.FileName, newTextFileForm.ContentText);
                }
            }
        }

        private void CreateNewTextFile(string fileName, string contentText)
        {
            string newFileName = Path.Combine(this.currentFolder, fileName);

            try
            {
                File.WriteAllText(newFileName, contentText);

                LoadAllFilesAndDirectories();
                ShowInfoLabel("Sucessfully created file");

            }
            catch (Exception ex)
            {
                ShowInfoLabelError("An error ouccured while creating the file: " + ex.Message);
            }

        }

        private void listViewFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.listViewFiles.SelectedItems.Count == 1)
            {
                string selectedPath = GetSelectedItemPath();

                FileAttributes fileAttributes = File.GetAttributes(selectedPath);

                if (CheckIfItemIsDirectory(fileAttributes))
                {
                    this.currentFolder = selectedPath;
                    this.textBoxFilePath.Text = selectedPath;
                    LoadAllFilesAndDirectories();
                }
                else
                {
                    OpenFile(selectedPath);
                }
            }
        }

        private string GetSelectedItemPath()
        {
            string selectedItem = this.listViewFiles.SelectedItems[0].Text;
            return Path.Combine(this.currentFolder, selectedItem);
        }

        private void OpenFile(string selectedPath)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = selectedPath,
                    UseShellExecute = false,
                });
            }
            catch (Exception ex)
            {
                ShowInfoLabelError("Error: " + ex.Message);

            }
        }

        private void listViewFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedItem();
            }
            else if (e.KeyCode == Keys.Back)
            {
                MoveFileOrDirBack();
            }

        }

        private void MoveFileOrDirBack()
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedItem()
        {
            if (this.listViewFiles.SelectedItems.Count > 0)
            {
                string selectedItem = GetSelectedItemPath();

                try
                {
                    DoDeleteSelectedItem(selectedItem);
                }
                catch (Exception ex)
                {
                    ShowInfoLabelError(ex.Message);
                }

                LoadAllFilesAndDirectories();
            }
        }

        private void DoDeleteSelectedItem(string selectedItem)
        {
            if (MessageBox.Show($"Are you sure you want to delete {selectedItem}?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            var fileAttributes = File.GetAttributes(selectedItem);

            if (CheckIfItemIsDirectory(fileAttributes))
            {
                DeleteDirectory(selectedItem);
            }
            else
            {
                DeleteFile(selectedItem);
            }
        }

        private void DeleteFile(string selectedItem)
        {
            File.Delete(selectedItem);
            ShowInfoLabel("Sucesfully deleted file");

        }

        private void DeleteDirectory(string selectedItem)
        {
            Directory.Delete(selectedItem, true);
            this.textBoxFilePath.Text = this.currentFolder;
            ShowInfoLabel("Sucesfully deleted folder");
        }

        private void listViewFiles_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listViewFiles.SelectedItems.Count > 0)
                {
                    string selectedItem = GetSelectedItemPath();

                    var fileAttributes = File.GetAttributes(selectedItem);
                    if (!CheckIfItemIsDirectory(fileAttributes))
                    {
                        UpdateFileInfoLabels(selectedItem);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowInfoLabel("This item is no longer available");
                LoadAllFilesAndDirectories();
            }
        }

        private void UpdateFileInfoLabels(string selectedItem)
        {
            this.textBoxFilePath.Text = selectedItem;

            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(selectedItem);
            this.labelFileNameValue.Text = fileNameWithoutExtension;

            string fileExtension = Path.GetExtension(selectedItem);
        }

        private void listViewFiles_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                var hitResult = listViewFiles.HitTest(e.Location);
                if (hitResult != null && hitResult.Item != null)
                {
                    this.draggedItem = hitResult.Item;
                    this.isItemBeingDragged = true;
                    this.draggedItemIndex = hitResult.Item.Index;
                    this.dragStart = e.Location;
                }
            }
            catch (Exception ex)
            {
                ShowInfoLabelError(ex.Message);
            }
        }

        private void listViewFiles_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isItemBeingDragged && this.draggedItem != null)
            {
                int deltaX = e.X - this.dragStart.X;
                int deltaY = e.Y - this.dragStart.Y;

                if (Math.Abs(deltaY) > SystemInformation.DragSize.Height
                    || Math.Abs(deltaX) > SystemInformation.DragSize.Width)
                {
                    this.listViewFiles.DoDragDrop(this.draggedItem, DragDropEffects.Move);
                    this.isItemBeingDragged = false;
                }
            }
        }

        private void listViewFiles_MouseUp(object sender, MouseEventArgs e)
        {
            this.isItemBeingDragged = false;
            this.draggedItem = null;
            this.draggedItemIndex = -1;
        }

        private void listViewFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listViewFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var clientPoint = this.listViewFiles.PointToClient(new Point(e.X, e.Y));
                int targetIndex = this.listViewFiles.InsertionMark.NearestIndex(clientPoint);

                if (targetIndex > -1 && targetIndex < this.listViewFiles.Items.Count)
                {
                    var targetItem = this.listViewFiles.Items[targetIndex];
                    string targetFolderName = targetItem.Text;

                    var itemToMove = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                    string fileName = itemToMove.Text;
                    string sourceFilePath = Path.Combine(this.currentFolder, fileName);

                    string destinationFolderPath = Path.Combine(currentFolder, targetFolderName);
                    string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

                    try
                    {
                        AttemptItemMove(targetIndex, targetFolderName, itemToMove, fileName, sourceFilePath, destinationFolderPath, destinationFilePath);
                    }
                    catch (Exception ex)
                    {
                        ShowInfoLabelError(ex.Message);
                    }

                }
            }

        }

        private void AttemptItemMove(int targetIndex, string targetFolderName, ListViewItem itemToMove, string fileName, string sourceFilePath, string destinationFolderPath, string destinationFilePath)
        {
            var sourceFileAttributes = File.GetAttributes(sourceFilePath);
            var destinationFolderAttributes = File.GetAttributes(destinationFilePath);

            if (CheckIfItemIsDirectory(sourceFileAttributes))
            {
                if (CheckIfItemIsDirectory(destinationFolderAttributes))
                {
                    MoveDirectory(sourceFilePath, destinationFilePath);
                }
                else
                {
                    throw new Exception("Destination shoule be a folder");
                }
            }
            else
            {
                MoveFile(sourceFilePath, destinationFilePath);
            }

            UpdateMovedItemDisplay(targetIndex, targetFolderName, itemToMove, fileName);
            LoadAllFilesAndDirectories();
        }

        private void UpdateMovedItemDisplay(int targetIndex, string targetFolderName, ListViewItem itemToMove, string fileName)
        {
            this.listViewFiles.Items.Remove(itemToMove);
            this.listViewFiles.Items.Insert(targetIndex, itemToMove);

            ShowInfoLabel("Success!");
        }

        private void MoveFile(string sourceFilePath, string destinationFilePath)
        {
            File.Move(sourceFilePath, destinationFilePath);
        }

        private void MoveDirectory(string sourceFilePath, string destinationFilePath)
        {
            Directory.Move(sourceFilePath, destinationFilePath);
        }

        private void listViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (this.listViewFiles.SelectedItems.Count > 0)
                {
                    string selectedPath = GetSelectedItemPath();

                    FileAttributes fileAttributes = File.GetAttributes(selectedPath);

                    if (CheckIfItemIsDirectory(fileAttributes))
                    {
                        this.textBoxFilePath.Text = selectedPath;
                        CleanFileInfo();
                    }
                    else
                    {
                        UpdateFileInfoLabels(selectedPath);
                    }
                }
                else
                {
                    CleanFileInfo();
                }

            }
            catch (Exception ex)
            {
                ShowInfoLabelError(ex.Message);
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadAllFilesAndDirectories();
        }
    }

}

