
namespace WindowsFormsApplication_LuckyTicket_59112
{
    partial class Form_Main
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
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.listBox_Enumerate = new System.Windows.Forms.ListBox();
            this.panel_Variants = new System.Windows.Forms.Panel();
            this.radioButton_VariantTask = new System.Windows.Forms.RadioButton();
            this.radioButton_VariantDefault = new System.Windows.Forms.RadioButton();
            this.button_CheckVariant = new System.Windows.Forms.Button();
            this.button_FindAllLucky = new System.Windows.Forms.Button();
            this.panel_Variants.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(49, 14);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(100, 23);
            this.textBox_Input.TabIndex = 0;
            // 
            // listBox_Enumerate
            // 
            this.listBox_Enumerate.FormattingEnabled = true;
            this.listBox_Enumerate.ItemHeight = 15;
            this.listBox_Enumerate.Location = new System.Drawing.Point(211, 14);
            this.listBox_Enumerate.Name = "listBox_Enumerate";
            this.listBox_Enumerate.Size = new System.Drawing.Size(162, 274);
            this.listBox_Enumerate.TabIndex = 1;
            // 
            // panel_Variants
            // 
            this.panel_Variants.Controls.Add(this.radioButton_VariantTask);
            this.panel_Variants.Controls.Add(this.radioButton_VariantDefault);
            this.panel_Variants.Location = new System.Drawing.Point(13, 48);
            this.panel_Variants.Name = "panel_Variants";
            this.panel_Variants.Size = new System.Drawing.Size(192, 120);
            this.panel_Variants.TabIndex = 2;
            // 
            // radioButton_VariantTask
            // 
            this.radioButton_VariantTask.AutoSize = true;
            this.radioButton_VariantTask.Location = new System.Drawing.Point(17, 68);
            this.radioButton_VariantTask.Name = "radioButton_VariantTask";
            this.radioButton_VariantTask.Size = new System.Drawing.Size(137, 19);
            this.radioButton_VariantTask.TabIndex = 1;
            this.radioButton_VariantTask.TabStop = true;
            this.radioButton_VariantTask.Text = "Вариант по заданию";
            this.radioButton_VariantTask.UseVisualStyleBackColor = true;
            // 
            // radioButton_VariantDefault
            // 
            this.radioButton_VariantDefault.AutoSize = true;
            this.radioButton_VariantDefault.Location = new System.Drawing.Point(17, 31);
            this.radioButton_VariantDefault.Name = "radioButton_VariantDefault";
            this.radioButton_VariantDefault.Size = new System.Drawing.Size(156, 19);
            this.radioButton_VariantDefault.TabIndex = 0;
            this.radioButton_VariantDefault.TabStop = true;
            this.radioButton_VariantDefault.Text = "Вариант по умолчанию";
            this.radioButton_VariantDefault.UseVisualStyleBackColor = true;
            // 
            // button_CheckVariant
            // 
            this.button_CheckVariant.Location = new System.Drawing.Point(13, 186);
            this.button_CheckVariant.Name = "button_CheckVariant";
            this.button_CheckVariant.Size = new System.Drawing.Size(192, 39);
            this.button_CheckVariant.TabIndex = 3;
            this.button_CheckVariant.Text = "Проверить вариант";
            this.button_CheckVariant.UseVisualStyleBackColor = true;
            this.button_CheckVariant.Click += new System.EventHandler(this.button_CheckVariant_Click);
            // 
            // button_FindAllLucky
            // 
            this.button_FindAllLucky.Location = new System.Drawing.Point(13, 249);
            this.button_FindAllLucky.Name = "button_FindAllLucky";
            this.button_FindAllLucky.Size = new System.Drawing.Size(192, 39);
            this.button_FindAllLucky.TabIndex = 4;
            this.button_FindAllLucky.Text = "Найти все счастливые числа";
            this.button_FindAllLucky.UseVisualStyleBackColor = true;
            this.button_FindAllLucky.Click += new System.EventHandler(this.button_FindAllLucky_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 301);
            this.Controls.Add(this.button_FindAllLucky);
            this.Controls.Add(this.button_CheckVariant);
            this.Controls.Add(this.panel_Variants);
            this.Controls.Add(this.listBox_Enumerate);
            this.Controls.Add(this.textBox_Input);
            this.Name = "Form_Main";
            this.Text = "Проверка счастливого билета";
            this.panel_Variants.ResumeLayout(false);
            this.panel_Variants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.ListBox listBox_Enumerate;
        private System.Windows.Forms.Panel panel_Variants;
        private System.Windows.Forms.RadioButton radioButton_VariantTask;
        private System.Windows.Forms.RadioButton radioButton_VariantDefault;
        private System.Windows.Forms.Button button_CheckVariant;
        private System.Windows.Forms.Button button_FindAllLucky;
    }
}

