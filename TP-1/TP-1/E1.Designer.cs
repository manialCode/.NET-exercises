namespace TP_1
{
    partial class E1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nameList1 = new ListBox();
            nameList2 = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            addButton = new Button();
            post = new Button();
            postAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Integrantes:";
            // 
            // nameList1
            // 
            nameList1.FormattingEnabled = true;
            nameList1.ItemHeight = 15;
            nameList1.Location = new Point(153, 82);
            nameList1.Name = "nameList1";
            nameList1.SelectionMode = SelectionMode.MultiExtended;
            nameList1.Size = new Size(120, 319);
            nameList1.TabIndex = 1;
            // 
            // nameList2
            // 
            nameList2.FormattingEnabled = true;
            nameList2.ItemHeight = 15;
            nameList2.Location = new Point(466, 82);
            nameList2.Name = "nameList2";
            nameList2.Size = new Size(120, 319);
            nameList2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 40);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese un Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(387, 40);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // post
            // 
            post.Location = new Point(329, 191);
            post.Name = "post";
            post.Size = new Size(75, 23);
            post.TabIndex = 6;
            post.Text = "->";
            post.UseVisualStyleBackColor = true;
            post.Click += post_Click;
            // 
            // postAll
            // 
            postAll.Location = new Point(329, 263);
            postAll.Name = "postAll";
            postAll.Size = new Size(75, 23);
            postAll.TabIndex = 7;
            postAll.Text = ">>";
            postAll.UseVisualStyleBackColor = true;
            postAll.Click += postAll_Click;
            // 
            // E1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(postAll);
            Controls.Add(post);
            Controls.Add(addButton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(nameList2);
            Controls.Add(nameList1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "E1";
            Text = "E1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox nameList1;
        private ListBox nameList2;
        private Label label2;
        private TextBox textBox1;
        private Button addButton;
        private Button post;
        private Button postAll;
    }
}