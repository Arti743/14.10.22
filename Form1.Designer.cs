
namespace Shop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Clothing = new System.Windows.Forms.Button();
            this.button_Workers = new System.Windows.Forms.Button();
            this.button_Positions = new System.Windows.Forms.Button();
            this.button_Orders = new System.Windows.Forms.Button();
            this.button_Cort = new System.Windows.Forms.Button();
            this.button_Types = new System.Windows.Forms.Button();
            this.button_Sex = new System.Windows.Forms.Button();
            this.button_Seasons = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_Seasons);
            this.panel1.Controls.Add(this.button_Sex);
            this.panel1.Controls.Add(this.button_Types);
            this.panel1.Controls.Add(this.button_Cort);
            this.panel1.Controls.Add(this.button_Orders);
            this.panel1.Controls.Add(this.button_Positions);
            this.panel1.Controls.Add(this.button_Workers);
            this.panel1.Controls.Add(this.button_Clothing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 302);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 302);
            this.panel2.TabIndex = 1;
            // 
            // button_Clothing
            // 
            this.button_Clothing.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Clothing.Location = new System.Drawing.Point(0, 0);
            this.button_Clothing.Name = "button_Clothing";
            this.button_Clothing.Size = new System.Drawing.Size(148, 37);
            this.button_Clothing.TabIndex = 0;
            this.button_Clothing.Text = "Clothing";
            this.button_Clothing.UseVisualStyleBackColor = true;
            this.button_Clothing.Click += new System.EventHandler(this.button_Clothing_Click);
            // 
            // button_Workers
            // 
            this.button_Workers.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Workers.Location = new System.Drawing.Point(0, 37);
            this.button_Workers.Name = "button_Workers";
            this.button_Workers.Size = new System.Drawing.Size(148, 37);
            this.button_Workers.TabIndex = 1;
            this.button_Workers.Text = "Workers";
            this.button_Workers.UseVisualStyleBackColor = true;
            this.button_Workers.Click += new System.EventHandler(this.button_Workers_Click);
            // 
            // button_Positions
            // 
            this.button_Positions.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Positions.Location = new System.Drawing.Point(0, 74);
            this.button_Positions.Name = "button_Positions";
            this.button_Positions.Size = new System.Drawing.Size(148, 37);
            this.button_Positions.TabIndex = 2;
            this.button_Positions.Text = "Positions";
            this.button_Positions.UseVisualStyleBackColor = true;
            this.button_Positions.Click += new System.EventHandler(this.button_Positions_Click);
            // 
            // button_Orders
            // 
            this.button_Orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Orders.Location = new System.Drawing.Point(0, 111);
            this.button_Orders.Name = "button_Orders";
            this.button_Orders.Size = new System.Drawing.Size(148, 37);
            this.button_Orders.TabIndex = 3;
            this.button_Orders.Text = "Orders";
            this.button_Orders.UseVisualStyleBackColor = true;
            this.button_Orders.Click += new System.EventHandler(this.button_Orders_Click);
            // 
            // button_Cort
            // 
            this.button_Cort.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Cort.Location = new System.Drawing.Point(0, 148);
            this.button_Cort.Name = "button_Cort";
            this.button_Cort.Size = new System.Drawing.Size(148, 37);
            this.button_Cort.TabIndex = 4;
            this.button_Cort.Text = "Cort";
            this.button_Cort.UseVisualStyleBackColor = true;
            this.button_Cort.Click += new System.EventHandler(this.button_Cort_Click);
            // 
            // button_Types
            // 
            this.button_Types.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Types.Location = new System.Drawing.Point(0, 185);
            this.button_Types.Name = "button_Types";
            this.button_Types.Size = new System.Drawing.Size(148, 37);
            this.button_Types.TabIndex = 5;
            this.button_Types.Text = "Types";
            this.button_Types.UseVisualStyleBackColor = true;
            this.button_Types.Click += new System.EventHandler(this.button_Types_Click);
            // 
            // button_Sex
            // 
            this.button_Sex.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Sex.Location = new System.Drawing.Point(0, 222);
            this.button_Sex.Name = "button_Sex";
            this.button_Sex.Size = new System.Drawing.Size(148, 37);
            this.button_Sex.TabIndex = 6;
            this.button_Sex.Text = "Sex";
            this.button_Sex.UseVisualStyleBackColor = true;
            this.button_Sex.Click += new System.EventHandler(this.button_Sex_Click);
            // 
            // button_Seasons
            // 
            this.button_Seasons.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Seasons.Location = new System.Drawing.Point(0, 259);
            this.button_Seasons.Name = "button_Seasons";
            this.button_Seasons.Size = new System.Drawing.Size(148, 37);
            this.button_Seasons.TabIndex = 7;
            this.button_Seasons.Text = "Seasons";
            this.button_Seasons.UseVisualStyleBackColor = true;
            this.button_Seasons.Click += new System.EventHandler(this.button_Seasons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(720, 302);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Shop";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Seasons;
        private System.Windows.Forms.Button button_Sex;
        private System.Windows.Forms.Button button_Types;
        private System.Windows.Forms.Button button_Cort;
        private System.Windows.Forms.Button button_Orders;
        private System.Windows.Forms.Button button_Positions;
        private System.Windows.Forms.Button button_Workers;
        private System.Windows.Forms.Button button_Clothing;
        private System.Windows.Forms.Panel panel2;
    }
}

