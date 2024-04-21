namespace VisualizadordeProdutos01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            meubotao = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "IPHONE", "SAMSUNG", "XIAOMI", "OPPO" });
            comboBox1.Location = new Point(204, 254);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(204, 306);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(156, 25);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(391, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 318);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(17, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 286);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(92, 257);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 3;
            label1.Text = "Marca:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 306);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 4;
            label2.Text = "Modelo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // meubotao
            // 
            meubotao.BackColor = Color.White;
            meubotao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            meubotao.ForeColor = Color.Red;
            meubotao.Location = new Point(240, 357);
            meubotao.Name = "meubotao";
            meubotao.Size = new Size(75, 28);
            meubotao.TabIndex = 6;
            meubotao.Text = "Limpar";
            meubotao.UseVisualStyleBackColor = false;
            meubotao.Click += pictureBox2_Click;
            meubotao.MouseCaptureChanged += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(793, 459);
            Controls.Add(meubotao);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Vizualizador de Produtos";
            Click += comboBox2_SelectedIndexChanged;
            DragLeave += comboBox1_SelectedIndexChanged;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button meubotao;
    }
}
