
namespace Lesson_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Next = new System.Windows.Forms.Button();
            this.pbx_Display = new System.Windows.Forms.PictureBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Engine = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(197, 305);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(100, 38);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "NEXT >>";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pbx_Display
            // 
            this.pbx_Display.Location = new System.Drawing.Point(12, 12);
            this.pbx_Display.Name = "pbx_Display";
            this.pbx_Display.Size = new System.Drawing.Size(352, 265);
            this.pbx_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Display.TabIndex = 2;
            this.pbx_Display.TabStop = false;
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Location = new System.Drawing.Point(24, 25);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(50, 16);
            this.lbl_Model.TabIndex = 3;
            this.lbl_Model.Text = "Model:";
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.AutoSize = true;
            this.lbl_Vendor.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.Location = new System.Drawing.Point(24, 79);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(57, 16);
            this.lbl_Vendor.TabIndex = 4;
            this.lbl_Vendor.Text = "Vendor:";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Location = new System.Drawing.Point(24, 137);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(41, 16);
            this.lbl_Year.TabIndex = 5;
            this.lbl_Year.Text = "Year:";
            // 
            // lbl_Engine
            // 
            this.lbl_Engine.AutoSize = true;
            this.lbl_Engine.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Engine.Location = new System.Drawing.Point(24, 197);
            this.lbl_Engine.Name = "lbl_Engine";
            this.lbl_Engine.Size = new System.Drawing.Size(55, 16);
            this.lbl_Engine.TabIndex = 6;
            this.lbl_Engine.Text = "Engine:";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(81, 305);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 38);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "<< BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 369);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Engine);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Vendor);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.pbx_Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.PictureBox pbx_Display;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label lbl_Vendor;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Engine;
        private System.Windows.Forms.Button btn_Back;
    }
}

