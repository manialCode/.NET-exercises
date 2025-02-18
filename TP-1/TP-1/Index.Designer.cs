
namespace TP_1
{
    partial class Index
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
            label1 = new Label();
            Ej1 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Juan Monti";
            // 
            // Ej1
            // 
            Ej1.Location = new Point(12, 45);
            Ej1.Name = "Ej1";
            Ej1.Size = new Size(186, 31);
            Ej1.TabIndex = 4;
            Ej1.Text = "Ejercico 1";
            Ej1.UseVisualStyleBackColor = true;
            Ej1.Click += Ej1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(468, 45);
            button1.Name = "button1";
            button1.Size = new Size(186, 31);
            button1.TabIndex = 5;
            button1.Text = "Ejercico 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(248, 45);
            button2.Name = "button2";
            button2.Size = new Size(186, 31);
            button2.TabIndex = 6;
            button2.Text = "Ejercico 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Ej1);
            Controls.Add(label1);
            Name = "Index";
            Text = "                 ";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label label1;
        private Button Ej1;
        private Button button1;
        private Button button2;
    }
}
