namespace project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.name = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.RichTextBox();
            this.Pancreas = new System.Windows.Forms.Button();
            this.liver = new System.Windows.Forms.Button();
            this.heart = new System.Windows.Forms.Button();
            this.Head = new System.Windows.Forms.Button();
            this.spleen = new System.Windows.Forms.Button();
            this.lung = new System.Windows.Forms.Button();
            this.intestine = new System.Windows.Forms.Button();
            this.colon = new System.Windows.Forms.Button();
            this.Brain = new System.Windows.Forms.Button();
            this.muscle = new System.Windows.Forms.Button();
            this.kidney = new System.Windows.Forms.Button();
            this.stomach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Yellow;
            this.name.CausesValidation = false;
            this.name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.name.Location = new System.Drawing.Point(117, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(66, 25);
            this.name.TabIndex = 15;
            this.name.Text = "部位";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detail
            // 
            this.detail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.detail.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.detail.Location = new System.Drawing.Point(12, 47);
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Size = new System.Drawing.Size(294, 391);
            this.detail.TabIndex = 18;
            this.detail.Text = resources.GetString("detail.Text");
            // 
            // Pancreas
            // 
            this.Pancreas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pancreas.BackgroundImage = global::project.Properties.Resources.pancreas;
            this.Pancreas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pancreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pancreas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pancreas.Location = new System.Drawing.Point(328, 314);
            this.Pancreas.Name = "Pancreas";
            this.Pancreas.Size = new System.Drawing.Size(100, 100);
            this.Pancreas.TabIndex = 11;
            this.Pancreas.UseVisualStyleBackColor = false;
            this.Pancreas.Click += new System.EventHandler(this.Brain_Click);
            this.Pancreas.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.Pancreas.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // liver
            // 
            this.liver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.liver.BackgroundImage = global::project.Properties.Resources.liver;
            this.liver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.liver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.liver.Location = new System.Drawing.Point(444, 314);
            this.liver.Name = "liver";
            this.liver.Size = new System.Drawing.Size(100, 100);
            this.liver.TabIndex = 10;
            this.liver.UseVisualStyleBackColor = false;
            this.liver.Click += new System.EventHandler(this.Brain_Click);
            this.liver.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.liver.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // heart
            // 
            this.heart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.heart.BackgroundImage = global::project.Properties.Resources.heart;
            this.heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.heart.Location = new System.Drawing.Point(565, 314);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(100, 100);
            this.heart.TabIndex = 9;
            this.heart.UseVisualStyleBackColor = false;
            this.heart.Click += new System.EventHandler(this.Brain_Click);
            this.heart.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.heart.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Head.BackgroundImage = global::project.Properties.Resources.hairstyle;
            this.Head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Head.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Head.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Head.Location = new System.Drawing.Point(329, 172);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(100, 100);
            this.Head.TabIndex = 8;
            this.Head.UseVisualStyleBackColor = false;
            this.Head.Click += new System.EventHandler(this.Brain_Click);
            this.Head.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.Head.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // spleen
            // 
            this.spleen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.spleen.BackgroundImage = global::project.Properties.Resources.spleen;
            this.spleen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spleen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spleen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spleen.Location = new System.Drawing.Point(688, 314);
            this.spleen.Name = "spleen";
            this.spleen.Size = new System.Drawing.Size(100, 100);
            this.spleen.TabIndex = 7;
            this.spleen.UseVisualStyleBackColor = false;
            this.spleen.Click += new System.EventHandler(this.Brain_Click);
            this.spleen.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.spleen.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // lung
            // 
            this.lung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lung.BackgroundImage = global::project.Properties.Resources.lungs;
            this.lung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lung.Location = new System.Drawing.Point(444, 172);
            this.lung.Name = "lung";
            this.lung.Size = new System.Drawing.Size(100, 100);
            this.lung.TabIndex = 6;
            this.lung.UseVisualStyleBackColor = false;
            this.lung.Click += new System.EventHandler(this.Brain_Click);
            this.lung.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.lung.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // intestine
            // 
            this.intestine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.intestine.BackgroundImage = global::project.Properties.Resources.intestine;
            this.intestine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.intestine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.intestine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.intestine.Location = new System.Drawing.Point(565, 172);
            this.intestine.Name = "intestine";
            this.intestine.Size = new System.Drawing.Size(100, 100);
            this.intestine.TabIndex = 5;
            this.intestine.UseVisualStyleBackColor = false;
            this.intestine.Click += new System.EventHandler(this.Brain_Click);
            this.intestine.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.intestine.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // colon
            // 
            this.colon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.colon.BackgroundImage = global::project.Properties.Resources.colon;
            this.colon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colon.Location = new System.Drawing.Point(688, 172);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(100, 100);
            this.colon.TabIndex = 4;
            this.colon.UseVisualStyleBackColor = false;
            this.colon.Click += new System.EventHandler(this.Brain_Click);
            this.colon.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.colon.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // Brain
            // 
            this.Brain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Brain.BackgroundImage = global::project.Properties.Resources.brain;
            this.Brain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brain.Location = new System.Drawing.Point(328, 33);
            this.Brain.Name = "Brain";
            this.Brain.Size = new System.Drawing.Size(100, 100);
            this.Brain.TabIndex = 3;
            this.Brain.UseVisualStyleBackColor = false;
            this.Brain.Click += new System.EventHandler(this.Brain_Click);
            this.Brain.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.Brain.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // muscle
            // 
            this.muscle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.muscle.BackgroundImage = global::project.Properties.Resources.muscle;
            this.muscle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.muscle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muscle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.muscle.Location = new System.Drawing.Point(444, 33);
            this.muscle.Name = "muscle";
            this.muscle.Size = new System.Drawing.Size(100, 100);
            this.muscle.TabIndex = 2;
            this.muscle.UseVisualStyleBackColor = false;
            this.muscle.Click += new System.EventHandler(this.Brain_Click);
            this.muscle.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.muscle.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // kidney
            // 
            this.kidney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kidney.BackgroundImage = global::project.Properties.Resources.kidneys;
            this.kidney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kidney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kidney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kidney.Location = new System.Drawing.Point(565, 33);
            this.kidney.Name = "kidney";
            this.kidney.Size = new System.Drawing.Size(100, 100);
            this.kidney.TabIndex = 1;
            this.kidney.UseVisualStyleBackColor = false;
            this.kidney.Click += new System.EventHandler(this.Brain_Click);
            this.kidney.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.kidney.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // stomach
            // 
            this.stomach.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stomach.BackgroundImage = global::project.Properties.Resources.stomach;
            this.stomach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stomach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stomach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stomach.Location = new System.Drawing.Point(688, 33);
            this.stomach.Name = "stomach";
            this.stomach.Size = new System.Drawing.Size(100, 100);
            this.stomach.TabIndex = 0;
            this.stomach.UseVisualStyleBackColor = false;
            this.stomach.Click += new System.EventHandler(this.Brain_Click);
            this.stomach.MouseLeave += new System.EventHandler(this.Brain_MouseLeave);
            this.stomach.MouseHover += new System.EventHandler(this.Brain_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Pancreas);
            this.Controls.Add(this.liver);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.spleen);
            this.Controls.Add(this.lung);
            this.Controls.Add(this.intestine);
            this.Controls.Add(this.colon);
            this.Controls.Add(this.Brain);
            this.Controls.Add(this.muscle);
            this.Controls.Add(this.kidney);
            this.Controls.Add(this.stomach);
            this.Name = "Form1";
            this.Text = "部位介面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stomach;
        private System.Windows.Forms.Button kidney;
        private System.Windows.Forms.Button muscle;
        private System.Windows.Forms.Button Brain;
        private System.Windows.Forms.Button colon;
        private System.Windows.Forms.Button intestine;
        private System.Windows.Forms.Button lung;
        private System.Windows.Forms.Button spleen;
        private System.Windows.Forms.Button Pancreas;
        private System.Windows.Forms.Button liver;
        private System.Windows.Forms.Button heart;
        private System.Windows.Forms.Button Head;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.RichTextBox detail;
    }
}

