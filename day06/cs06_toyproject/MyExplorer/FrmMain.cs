using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace MyExplorer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // ���� �⺻, ������� �����
        private void FrmMain_Load(object sender, EventArgs e)
        {
            TreeNode root = TrvFolder.Nodes.Add("�� ��ǻ��");

            string[] drives = Directory.GetLogicalDrives(); // �� ��ǻ�� ������̺�
            foreach (var drive in drives)
            {
                TreeNode node = root.Nodes.Add(drive);
                node.Nodes.Add("..."); // ���� ������
            }
            //LsvFile.View = View.LargeIcon;
        }

        //�����ư Ŭ�� �̺�Ʈ�ڵ鷯
        private void BtnOpen_Click(object sender, EventArgs e)
        {

        }

        // Ʈ����� ������ �̺�Ʈ�ڵ鷯
        private void TrvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // �������� ��� �����ϸ� ����Ʈ�信 ����ǥ��
            TreeNode current = e.Node;
            if (e.Node == null) return;

            string path = current.FullPath.Replace("\\\\", "\\");
            TxtPath.Text = path.Substring(path.IndexOf("\\") + 1);  // '�� ��ǻ��\' ����
            try
            {
                LsvFile.Items.Clear();  // �ٸ� ������ �ִ� �������� ���� ����
                                        // ���������� �������� ���� ���÷���
                string[] directories = Directory.GetDirectories(TxtPath.Text);
                foreach (var directory in directories)
                {
                    DirectoryInfo info = new DirectoryInfo(directory);
                    // ����Ʈ�� �÷� �̸�, ��������, ����, ũ�� ������ ����Ʈ�� ������ ����
                    // ���ڿ� �� : "", string.Empty
                    ListViewItem item = new ListViewItem(new string[] { info.Name, info.LastWriteTime.ToString(), "��������", string.Empty });
                    item.ImageIndex = 1; //����Ʈ���� ���� �̹��� �ε���
                    LsvFile.Items.Add(item);
                }
                // ���� ����Ʈ��
                string[] files = Directory.GetFiles(TxtPath.Text); // ���� �������� ���� ����
                foreach (var file in files)
                {
                    FileInfo info = new FileInfo(file);
                    ListViewItem item = new ListViewItem(new string[] { info.Name, info.LastWriteTime.ToString(), info.Extension, info.Length.ToString() });
                    item.ImageIndex = GetImageIndex(info.Extension);
                    LsvFile.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetImageIndex(string extension)
        {
            // 3 : ��������, 4 : �Ϲ�����, 5 : txt����
            var index = -1;
            switch (extension.ToLower())
            {
                case ".exe":
                    index = 3;
                    break;
                case ".txt":
                    index = 5;
                    break;
                default:
                    index = 4;
                    break;
            }
            return index;
        }

        // Ʈ��Ȯ����� ������ Ŭ���ؼ� Ȯ��Ǳ� ���� �̺�Ʈ �ڵ鷯

        private void TrvFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode current = e.Node;
            // ���� �ε�� �� ������ ���¶��
            if (current.Nodes.Count == 1 && current.Nodes[0].Text.Equals("..."))
            {
                current.Nodes.Clear();
                // FullPath, �� ��ǻ��\c:\
                String path = current.FullPath.Substring(current.FullPath.IndexOf("\\") + 1);
                try
                {
                    string[] directories = Directory.GetDirectories(path);
                    foreach (var directory in directories)
                    {
                        Debug.WriteLine(directory); // ����׽ø� ��µ�
                        TreeNode newNode = current.Nodes.Add(directory.Substring(directory.LastIndexOf("\\") + 1));
                        newNode.ImageIndex = 1; // �̼��ý� ���� �̹���
                        newNode.SelectedImageIndex = 2; // ���ý� ���� �̹���
                        newNode.Nodes.Add("...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LsvFile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // ���ؽ�Ʈ�޴��� ������ ��ư������ ����
                CmsFiles.Show(LsvFile, e.Location); // ���콺 Ŭ���� ��ġ�� ��
            }
        }

        private void TstMenuLargeIcon_Click(object sender, EventArgs e)
        {
            LsvFile.View = View.LargeIcon;
        }

        private void TstMenuSmallIcon_Click(object sender, EventArgs e)
        {
            LsvFile.View = View.SmallIcon;

        }

        private void TstMenuListIcon_Click(object sender, EventArgs e)
        {
            LsvFile.View = View.List;
        }

        private void TstMenuDetailIcon_Click(object sender, EventArgs e)
        {
            LsvFile.View = View.Details;
        }

        private void TstMenuTaliIcon_Click(object sender, EventArgs e)
        {
            LsvFile.View = View.Tile;
        }

        // ����Ʈ�� ������ ����Ŭ�� �̺�Ʈ�ڵ鷯, �������� ����
        private void LsvFile_DoubleClick(object sender, EventArgs e)
        {
            try
            {
            var extension = LsvFile.SelectedItems[0].Text.Split(".")[1];
            if (extension == "exe")
            {   // ���������̸�
                //MessageBox.Show(LsvFile.SelectedItems[0].Text); // ������
                //���������� ��δ� TxtPath
                var fullPath = TxtPath.Text + "\\" + LsvFile.SelectedItems[0].Text;
                Process.Start(fullPath);
            }  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

