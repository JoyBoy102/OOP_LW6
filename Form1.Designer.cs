namespace WinFormsApp1
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            Menu = new GroupBox();
            chooseClass = new ComboBox();
            pictureBox1 = new PictureBox();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(240, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(258, 17);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Выделение двух фигур при их пересечении";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(240, 59);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(239, 17);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Включить выделение нескольких фигур";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            Menu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Menu.Controls.Add(chooseClass);
            Menu.Controls.Add(checkBox2);
            Menu.Controls.Add(checkBox1);
            Menu.Dock = DockStyle.Bottom;
            Menu.Font = new Font("Segoe UI", 25F);
            Menu.Location = new Point(0, 507);
            Menu.Name = "Menu";
            Menu.Size = new Size(829, 102);
            Menu.TabIndex = 3;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            // 
            // chooseClass
            // 
            chooseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            chooseClass.Font = new Font("Segoe UI", 10F);
            chooseClass.FormattingEnabled = true;
            chooseClass.Items.AddRange(new object[] { "Круг", "Квадрат", "Треугольник" });
            chooseClass.Location = new Point(12, 51);
            chooseClass.Name = "chooseClass";
            chooseClass.Size = new Size(201, 25);
            chooseClass.TabIndex = 0;
            chooseClass.KeyDown += chooseClass_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 489);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 609);
            Controls.Add(pictureBox1);
            Controls.Add(Menu);
            MinimumSize = new Size(300, 300);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox Menu;
        private ComboBox chooseClass;
        private PictureBox pictureBox1;
    }
}
