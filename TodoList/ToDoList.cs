using Microsoft.VisualBasic.Devices;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace TodoList
{
    public partial class ToDoList : Form
    {
        private const string nomeArquivo = ".\\tarefas.txt";

        private int checkTarefas = 0;
        private int quantidadeTarefas = 0;

        private List<string> tarefas = new List<string>();

        public int CheckTarefas
        {
            get { return checkTarefas; }
            set { checkTarefas = value; }
        }

        public int QuantidadeTarefas
        {
            get { return quantidadeTarefas; }
            set { quantidadeTarefas = value; }
        }

        public ToDoList()
        {
            InitializeComponent();
            buttonLimpar.Click += ButtonLimpar_Click;
            CarregarTarefasArquivo(nomeArquivo);
        }

        private void AddItem(string text, string labelName, bool gravarTarefas = false)
        {
            char.ToUpper(text[0]);

            if (gravarTarefas)
            {
                tarefas.Add(text);
                SalvarTarefasEmArquivo(nomeArquivo);
            }

            Panel panel = new Panel();
            panel.Size = new Size(flowLayoutPanel.Width - 10, 30);
            panel.BackColor = Color.Gainsboro;
            
            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new Point(10, 8);

            Label label = new Label();
            label.Text = text;
            label.Name = labelName;
            label.Font = new Font("Consolas", 12, FontStyle.Italic);
            label.AutoSize = true;
            label.Location = new Point(30, 4);

            PictureBox deletePictureBox = new PictureBox();
            deletePictureBox.Size = new Size(20, 20);
            deletePictureBox.Location = new Point(panel.Width - 30, 5);
            deletePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            deletePictureBox.Cursor = Cursors.Hand;
            deletePictureBox.Image = System.Drawing.Image.FromFile(@".\remove.png");

            deletePictureBox.Click += (s, e) => 
            { 
                flowLayoutPanel.Controls.Remove(panel);
                QuantidadeTarefas--;
                tarefas[Convert.ToInt32(label.Name)] = null;
                SalvarTarefasEmArquivo(nomeArquivo);
                UpdateTasksPendentesLabel();
            };

            checkBox.CheckedChanged += (s, e) =>
            {
                if (checkBox.Checked)
                {
                    label.Font = new Font(label.Font, FontStyle.Strikeout | FontStyle.Italic);
                    label.ForeColor = Color.DodgerBlue;
                    CheckTarefas++; 
                }
                else
                {
                    CheckTarefas--;
                    label.Font = new Font(label.Font, FontStyle.Italic);
                    label.ForeColor = SystemColors.ControlText;
                }
                UpdateTasksPendentesLabel();
            };

            panel.Controls.Add(checkBox);
            panel.Controls.Add(label);
            panel.Controls.Add(deletePictureBox);
            flowLayoutPanel.Controls.Add(panel);
            QuantidadeTarefas++;
            UpdateTasksPendentesLabel();
        }

        private void SalvarTarefasEmArquivo(string arquivo)
        {
            try
            {
                File.WriteAllLines(arquivo, tarefas);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Erro ao salvar as tarefas: " + ex.Message);
            }
        }

        private void CarregarTarefasArquivo(string arquivo)
        {
            try
            {
                if (File.Exists(arquivo))
                {
                    int i = 0;
                    tarefas = new List<string>(File.ReadAllLines(arquivo));
                    tarefas.RemoveAll(item => item == "");

                    foreach(string tf in tarefas)
                    {
                        AddItem(tf, Convert.ToString(i));
                        i++;
                    }
                }
            }
            catch (IOException ex) 
            {
                MessageBox.Show("Erro ao carregas suas tarefas: " + ex.Message);
            }
         }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            string tarefa = textBoxTarefa.Text;

            if (!string.IsNullOrWhiteSpace(tarefa))
            {
                AddItem(textBoxTarefa.Text, $"{tarefas.Count - 1}", true);
                textBoxTarefa.Clear();
            }
            else
            {
                MessageBox.Show("Digite uma tarefa antes de adicionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            CheckTarefas = 0;
            QuantidadeTarefas = 0;
            tarefas = new List<string>();
            SalvarTarefasEmArquivo(nomeArquivo);
            UpdateTasksPendentesLabel();
            flowLayoutPanel.Controls.Clear();
        }

        private void UpdateTasksPendentesLabel()
        {
            labelPendingTasks.Text = $"{QuantidadeTarefas - CheckTarefas} tarefa(s) pendentes";
        }
    }
}