
namespace LR4
{
    partial class fMain
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
            this.tbPlaineInfo = new System.Windows.Forms.TextBox();
            this.btnAddPlane = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPlaineInfo
            // 
            this.tbPlaineInfo.Location = new System.Drawing.Point(9, 10);
            this.tbPlaineInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbPlaineInfo.Multiline = true;
            this.tbPlaineInfo.Name = "tbPlaineInfo";
            this.tbPlaineInfo.ReadOnly = true;
            this.tbPlaineInfo.Size = new System.Drawing.Size(274, 204);
            this.tbPlaineInfo.TabIndex = 0;
            // 
            // btnAddPlane
            // 
            this.btnAddPlane.Location = new System.Drawing.Point(303, 11);
            this.btnAddPlane.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlane.Name = "btnAddPlane";
            this.btnAddPlane.Size = new System.Drawing.Size(106, 40);
            this.btnAddPlane.TabIndex = 2;
            this.btnAddPlane.Text = "Додати місто";
            this.btnAddPlane.UseVisualStyleBackColor = true;
            this.btnAddPlane.Click += new System.EventHandler(this.btnAddPlane_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(303, 64);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 222);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPlane);
            this.Controls.Add(this.tbPlaineInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛР№4 Ковінько В. Варіант №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlaineInfo;
        private System.Windows.Forms.Button btnAddPlane;
        private System.Windows.Forms.Button btnClose;
    }
}

