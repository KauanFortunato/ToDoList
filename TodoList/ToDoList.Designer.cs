namespace TodoList
{
    partial class ToDoList
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.titleTodolist = new System.Windows.Forms.Label();
            this.textBoxTarefa = new System.Windows.Forms.RichTextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelPendingTasks = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleTodolist
            // 
            resources.ApplyResources(this.titleTodolist, "titleTodolist");
            this.titleTodolist.BackColor = System.Drawing.Color.Transparent;
            this.titleTodolist.ForeColor = System.Drawing.Color.DodgerBlue;
            this.titleTodolist.Name = "titleTodolist";
            // 
            // textBoxTarefa
            // 
            this.textBoxTarefa.BackColor = System.Drawing.Color.White;
            this.textBoxTarefa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxTarefa, "textBoxTarefa");
            this.textBoxTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTarefa.Name = "textBoxTarefa";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonAdicionar, "buttonAdicionar");
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonAdicionar.FlatAppearance.BorderSize = 0;
            this.buttonAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAdicionar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // labelPendingTasks
            // 
            resources.ApplyResources(this.labelPendingTasks, "labelPendingTasks");
            this.labelPendingTasks.Name = "labelPendingTasks";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonLimpar, "buttonLimpar");
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.textBoxTarefa);
            this.panel1.Controls.Add(this.buttonAdicionar);
            this.panel1.Controls.Add(this.titleTodolist);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.labelPendingTasks);
            this.panel2.Controls.Add(this.buttonLimpar);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(this.flowLayoutPanel, "flowLayoutPanel");
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // ToDoList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "ToDoList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleTodolist;
        private System.Windows.Forms.RichTextBox textBoxTarefa;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelPendingTasks;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}

