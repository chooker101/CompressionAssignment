using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Windows.Forms;

namespace zip
{
    class GZip
    {
        /*
            DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
            Compress(directorySelected);

            foreach (FileInfo fileToDecompress in directorySelected.GetFiles("*.gz"))
            {
                Decompress(fileToDecompress);
            }
       */

        public static void Compress(DirectoryInfo directorySelected,string path)
        {
            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) &
                       FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                               CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);

                            }
                        }
                        FileInfo info = new FileInfo(path + "\\" + fileToCompress.Name + ".gz");
                        
                        // fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString();
                        
                    }

                }
            }
        }

        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }
    }
}

namespace CompressionAssigment
{
    public partial class CarstensZipper : Form
    {
        public CarstensZipper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                totextbox.Text = folderBrowser.SelectedPath;

            }
             
        }

        private void FromBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {

                fromtextbox.Text = folderBrowser.SelectedPath;

            }
        }

        private void settingdrop_Change(object sender, EventArgs e)
        {
        }

        private void setfilter_Checked(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

    public void ZipFilter(string currdirectory)
        {
            using (FileStream zipToOpen = new FileStream(totextbox.Text + "\\" + zipname.Text + ".zip", FileMode.OpenOrCreate))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    string[] files = Directory.GetFiles(currdirectory);
                    foreach (string name in files)
                    {
                        string filter = filtertext.Text;
                        string filename = name.Remove(0, currdirectory.Length);
                        int start = (filename.Length - filter.Length);
                        filename = filename.Remove(start, filename.Length - start);
                        filename = filename.Remove(0, 1);
                        string check = (currdirectory + "\\" + filename + filtertext.Text);
                        //MessageBox.Show(name);
                        //MessageBox.Show(check);
                        if (name == check)
                        {
                            //MessageBox.Show(filename);
                            archive.CreateEntry(filename+filtertext.Text);
                        }
                    }
                }
            }
            string[] subdirectorys = Directory.GetDirectories(currdirectory);
            foreach (string subname in subdirectorys)
            {
                ZipFilter(subname);
            }
        }

        private void begin_Click(object sender, EventArgs e)
        {
            switch (settingdrop.Text)
            {
                case "Zip":
                {
						switch (methoddrop.Text)
						{
							default:
							case "Zip":
								{
									if(setfilter.Checked)
									{
                                        string path = fromtextbox.Text;
                                        ZipFilter(path);
                                        MessageBox.Show("Success");
                                    }
									else
									{
                                        ZipFile.CreateFromDirectory(fromtextbox.Text, totextbox.Text + "\\" + zipname.Text + ".zip");
                                        MessageBox.Show("Success");

                                    }
									break;
								}
							case "GZip":
								{
                                    DirectoryInfo directorySelected = new DirectoryInfo(fromtextbox.Text);
                                    zip.GZip.Compress(directorySelected,totextbox.Text);
                                    break;
								}
							case "7z":
								{
									break;
								}
						}

					break;
                }
				case "Unzip":
				{
						switch (methoddrop.Text)
						{
							default:
							case "Zip":
								{
									if (setfilter.Checked)
									{
                                        MessageBox.Show("CantFilter");
                                    }
									else
									{
										ZipFile.ExtractToDirectory(fromtextbox.Text + "\\" + zipname.Text + ".zip", totextbox.Text);
                                        MessageBox.Show("Success");
                                    }
									break;
								}
							case "GZip":
								{
                                    DirectoryInfo directorySelected = new DirectoryInfo(fromtextbox.Text);
                                    foreach (FileInfo fileToDecompress in directorySelected.GetFiles("*.gz"))
                                    {
                                        zip.GZip.Decompress(fileToDecompress);
                                    }
                                    break;
								}
							case "7z":
								{
									break;
								}
						}

						break;
				}
				case "Add":
                    {
                        if (methoddrop.Text == "Zip")
                        {
                            if (setfilter.Checked)
                            {
                                string path = fromtextbox.Text;
                                ZipFilter(path);
                                MessageBox.Show("Success");
                            }
                            else
                            {
                                using (FileStream zipToOpen = new FileStream(totextbox.Text + "\\" + zipname.Text + ".zip", FileMode.OpenOrCreate))
                                {
                                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                                    {
                                        string[] files = Directory.GetFiles(fromtextbox.Text);
                                        foreach (string name in files)
                                        {
                                            string count = fromtextbox.Text;
                                            string filename = name.Remove(0, count.Length);

                                            filename = filename.Remove(0, 1);

                                            archive.CreateEntry(filename);

                                        }
                                    }
                                }
                                MessageBox.Show("Success");
                            }
                        }
                        else
                        {
                            MessageBox.Show("CantAdd");
                        }
                        break;
				}
				default:
					{
                        MessageBox.Show("Error no setting selected");
                        break;
					}
			}
        }
    }
}
