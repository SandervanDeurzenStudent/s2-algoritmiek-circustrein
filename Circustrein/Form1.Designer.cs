namespace Circustrein
{
    partial class Form1
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
            this.lb_wagon_desc = new System.Windows.Forms.ListBox();
            this.lb_added_desc = new System.Windows.Forms.ListBox();
            this.Btn_send = new System.Windows.Forms.Button();
            this.cb_format = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_animalType = new System.Windows.Forms.ComboBox();
            this.btn_sortAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_wagon_desc
            // 
            this.lb_wagon_desc.FormattingEnabled = true;
            this.lb_wagon_desc.Location = new System.Drawing.Point(128, 64);
            this.lb_wagon_desc.Name = "lb_wagon_desc";
            this.lb_wagon_desc.Size = new System.Drawing.Size(213, 199);
            this.lb_wagon_desc.TabIndex = 0;
            // 
            // lb_added_desc
            // 
            this.lb_added_desc.FormattingEnabled = true;
            this.lb_added_desc.Location = new System.Drawing.Point(395, 64);
            this.lb_added_desc.Name = "lb_added_desc";
            this.lb_added_desc.Size = new System.Drawing.Size(201, 199);
            this.lb_added_desc.TabIndex = 1;
            // 
            // Btn_send
            // 
            this.Btn_send.Location = new System.Drawing.Point(527, 349);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(115, 43);
            this.Btn_send.TabIndex = 2;
            this.Btn_send.Text = "Add Animal";
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // cb_format
            // 
            this.cb_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_format.FormattingEnabled = true;
            this.cb_format.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cb_format.Location = new System.Drawing.Point(273, 349);
            this.cb_format.Name = "cb_format";
            this.cb_format.Size = new System.Drawing.Size(121, 21);
            this.cb_format.TabIndex = 3;
            this.cb_format.SelectedIndexChanged += new System.EventHandler(this.cb_format_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 4;
            // 
            // cb_animalType
            // 
            this.cb_animalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_animalType.FormattingEnabled = true;
            this.cb_animalType.Items.AddRange(new object[] {
            "Carnivore",
            "Herbivore"});
            this.cb_animalType.Location = new System.Drawing.Point(400, 349);
            this.cb_animalType.Name = "cb_animalType";
            this.cb_animalType.Size = new System.Drawing.Size(121, 21);
            this.cb_animalType.TabIndex = 5;
            // 
            // btn_sortAnimals
            // 
            this.btn_sortAnimals.Location = new System.Drawing.Point(527, 395);
            this.btn_sortAnimals.Name = "btn_sortAnimals";
            this.btn_sortAnimals.Size = new System.Drawing.Size(115, 43);
            this.btn_sortAnimals.TabIndex = 6;
            this.btn_sortAnimals.Text = "Add Animal";
            this.btn_sortAnimals.UseVisualStyleBackColor = true;
            this.btn_sortAnimals.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sortAnimals);
            this.Controls.Add(this.cb_animalType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_format);
            this.Controls.Add(this.Btn_send);
            this.Controls.Add(this.lb_added_desc);
            this.Controls.Add(this.lb_wagon_desc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_wagon_desc;
        private System.Windows.Forms.ListBox lb_added_desc;
        private System.Windows.Forms.Button Btn_send;
        private System.Windows.Forms.ComboBox cb_format;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_animalType;
        private System.Windows.Forms.Button btn_sortAnimals;
    }
}

