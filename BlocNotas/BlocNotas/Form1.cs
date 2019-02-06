using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocNotas
{
    public partial class FormBlocNotas : Form
    {
        public FormBlocNotas()
        {
            InitializeComponent();

            this.Text = "Nuevo Documento";
            tsStatusLabel.Text = "Línea: 1";
        }

        private bool nuevoDoc = true;

        // --ARCHIVO--

        // Nuevo
        private void msArchivoNuevo_Click(object sender, EventArgs e)
        {
            if(!richTextBox.Text.Equals(""))
            {
                if(MessageBox.Show("¿Desea guardar los cambios en el documento antes de abrir uno nuevo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(!this.Text.Equals("Nuevo Documento"))
                    {
                        richTextBox.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
                        this.Text = "Nuevo Documento";
                        richTextBox.Clear();
                    }
                    else
                    {
                        nuevoDoc = true;
                        saveFileDialog.FileName = "Nuevo_Documento.txt";
                        saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                        saveFileDialog.Title = "Guardar Documento";
                        saveFileDialog.ShowDialog();
                    }
                }
                else
                {
                    this.Text = "Nuevo Documento";
                    richTextBox.Clear();
                }
            }
            else
            {
                this.Text = "Nuevo Documento";
                richTextBox.Clear();
            }
        }

        private void tsBtnNuevo_Click(object sender, EventArgs e)
        {
            if (!richTextBox.Text.Equals(""))
            {
                if (MessageBox.Show("¿Desea guardar los cambios en el documento antes de abrir uno nuevo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!this.Text.Equals("Nuevo Documento"))
                    {
                        richTextBox.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
                        this.Text = "Nuevo Documento";
                        richTextBox.Clear();
                    }
                    else
                    {
                        nuevoDoc = true;
                        saveFileDialog.FileName = "Nuevo_Documento.txt";
                        saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                        saveFileDialog.Title = "Guardar Documento";
                        saveFileDialog.ShowDialog();
                    }
                }
                else
                {
                    this.Text = "Nuevo Documento";
                    richTextBox.Clear();
                }
            }
            else
            {
                this.Text = "Nuevo Documento";
                richTextBox.Clear();
            }
        }

        // Abrir
        private void msArchivoAbrir_Click(object sender, EventArgs e)
        {
            if (!richTextBox.Text.Equals(""))
            {
                if (MessageBox.Show("¿Desea guardar los cambios en el documento antes de abrir uno nuevo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    richTextBox.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
                    openFileDialog.FileName = "";
                    openFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                    openFileDialog.Title = "Abrir Documento";
                    openFileDialog.ShowDialog();
                }
                else
                {
                    openFileDialog.FileName = "";
                    openFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                    openFileDialog.Title = "Abrir Documento";
                    openFileDialog.ShowDialog();
                }
            }
            else
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                openFileDialog.Title = "Abrir Documento";
                openFileDialog.ShowDialog();
            }
        }
        
        private void tsBtnAbrir_Click(object sender, EventArgs e)
        {
            if (!richTextBox.Text.Equals(""))
            {
                if (MessageBox.Show("¿Desea guardar los cambios en el documento antes de abrir uno nuevo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    richTextBox.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
                    openFileDialog.FileName = "";
                    openFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                    openFileDialog.Title = "Abrir Documento";
                    openFileDialog.ShowDialog();
                }
                else
                {
                    openFileDialog.FileName = "";
                    openFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                    openFileDialog.Title = "Abrir Documento";
                    openFileDialog.ShowDialog();
                }
            }
            else
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                openFileDialog.Title = "Abrir Documento";
                openFileDialog.ShowDialog();
            }
        }

        // Guardar
        private void msArchivoGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Text.Equals("Nuevo Documento"))
            {
                richTextBox.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
            }
            else
            {
                nuevoDoc = false;
                saveFileDialog.FileName = "Nuevo_Documento";
                saveFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                saveFileDialog.Title = "Guardar Documento";
                saveFileDialog.ShowDialog();
            }
        }
        
        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Text.Equals("Nuevo Documento"))
            {
                richTextBox.SaveFile(this.Text, RichTextBoxStreamType.PlainText);
            }
            else
            {
                nuevoDoc = false;
                saveFileDialog.FileName = "Nuevo_Documento";
                saveFileDialog.Filter = "Archivos de texto|*.txt;*.rtf";
                saveFileDialog.Title = "Guardar Documento";
                saveFileDialog.ShowDialog();
            }
        }

        // Salir
        private void msArchivoSalir_Click(object sender, EventArgs e)
        {
            if (!richTextBox.Text.Equals(""))
            {
                if (MessageBox.Show("¿Seguro que desea salir sin guardar los cambios?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        // SaveFileDialog
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if(nuevoDoc)
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = "Nuevo Documento";
                richTextBox.Clear();
            }
            else
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog.FileName;
            }
        }

        // OpenFileDialog
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.Text = openFileDialog.FileName;
            richTextBox.LoadFile(this.Text, RichTextBoxStreamType.PlainText);
        }

        // --EDICION--

        // Cortar
        private void msEdicionCortar_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
        }

        private void tsBtnCortar_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
        }

        // Copiar
        private void msEdicionCopiar_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox.SelectedText);
            }
        }

        private void tsBtnCopiar_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox.SelectedText);
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox.SelectedText);
            }
        }

        // Pegar
        private void msEdicionPegar_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            
            if (iData.GetDataPresent(DataFormats.Text))
            {
                richTextBox.SelectedText = (String)iData.GetData(DataFormats.Text);
            }
        }

        private void tsBtnPegar_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                richTextBox.SelectedText = (String)iData.GetData(DataFormats.Text);
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                richTextBox.SelectedText = (String)iData.GetData(DataFormats.Text);
            }
        }

        // Buscar
        private void msEdicionBuscar_Click(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el texto a buscar:", "Buscar");
            richTextBox.Find(text);
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el texto a buscar:", "Buscar");
            richTextBox.Find(text);
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el texto a buscar:", "Buscar");
            richTextBox.Find(text);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el texto a buscar:", "Buscar");
            richTextBox.Find(text);
        }

        // Fuente
        private void msEdicionFuente_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            richTextBox.Font = fontDialog.Font;
        }

        private void tsBtnFuente_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            richTextBox.Font = fontDialog.Font;
        }

        // Color
        private void msEdicionColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            richTextBox.ForeColor = colorDialog.Color;
        }

        private void tsBtnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            richTextBox.ForeColor = colorDialog.Color;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            richTextBox.ForeColor = colorDialog.Color;
        }

        // SelectionChanged
        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            tsStatusLabel.Text = "Línea: " + (richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart)+1);
        }
    }
}
