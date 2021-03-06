﻿namespace MsCrmTools.WebResourcesManager.UserControls
{
    partial class WebResourceTypePicker
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkIco = new System.Windows.Forms.CheckBox();
            this.chkXsl = new System.Windows.Forms.CheckBox();
            this.chkXap = new System.Windows.Forms.CheckBox();
            this.chkGif = new System.Windows.Forms.CheckBox();
            this.chkJpeg = new System.Windows.Forms.CheckBox();
            this.chkPng = new System.Windows.Forms.CheckBox();
            this.chkXml = new System.Windows.Forms.CheckBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.chkSvg = new System.Windows.Forms.CheckBox();
            this.chkResx = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkResx);
            this.groupBox2.Controls.Add(this.chkSvg);
            this.groupBox2.Controls.Add(this.chkAll);
            this.groupBox2.Controls.Add(this.chkIco);
            this.groupBox2.Controls.Add(this.chkXsl);
            this.groupBox2.Controls.Add(this.chkXap);
            this.groupBox2.Controls.Add(this.chkGif);
            this.groupBox2.Controls.Add(this.chkJpeg);
            this.groupBox2.Controls.Add(this.chkPng);
            this.groupBox2.Controls.Add(this.chkXml);
            this.groupBox2.Controls.Add(this.chkJavaScript);
            this.groupBox2.Controls.Add(this.chkCss);
            this.groupBox2.Controls.Add(this.chkHtml);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load only these file types";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(5, 25);
            this.chkAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(37, 17);
            this.chkAll.TabIndex = 10;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkIco
            // 
            this.chkIco.AutoSize = true;
            this.chkIco.Checked = true;
            this.chkIco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIco.Enabled = false;
            this.chkIco.Location = new System.Drawing.Point(338, 47);
            this.chkIco.Name = "chkIco";
            this.chkIco.Size = new System.Drawing.Size(44, 17);
            this.chkIco.TabIndex = 9;
            this.chkIco.Tag = ".ico";
            this.chkIco.Text = "ICO";
            this.chkIco.UseVisualStyleBackColor = true;
            // 
            // chkXsl
            // 
            this.chkXsl.AutoSize = true;
            this.chkXsl.Checked = true;
            this.chkXsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXsl.Enabled = false;
            this.chkXsl.Location = new System.Drawing.Point(242, 94);
            this.chkXsl.Name = "chkXsl";
            this.chkXsl.Size = new System.Drawing.Size(46, 17);
            this.chkXsl.TabIndex = 8;
            this.chkXsl.Tag = ".xsl|.xslt";
            this.chkXsl.Text = "XSL";
            this.chkXsl.UseVisualStyleBackColor = true;
            // 
            // chkXap
            // 
            this.chkXap.AutoSize = true;
            this.chkXap.Checked = true;
            this.chkXap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXap.Enabled = false;
            this.chkXap.Location = new System.Drawing.Point(242, 71);
            this.chkXap.Name = "chkXap";
            this.chkXap.Size = new System.Drawing.Size(47, 17);
            this.chkXap.TabIndex = 7;
            this.chkXap.Tag = ".xap";
            this.chkXap.Text = "XAP";
            this.chkXap.UseVisualStyleBackColor = true;
            // 
            // chkGif
            // 
            this.chkGif.AutoSize = true;
            this.chkGif.Checked = true;
            this.chkGif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGif.Enabled = false;
            this.chkGif.Location = new System.Drawing.Point(242, 47);
            this.chkGif.Name = "chkGif";
            this.chkGif.Size = new System.Drawing.Size(43, 17);
            this.chkGif.TabIndex = 6;
            this.chkGif.Tag = ".gif";
            this.chkGif.Text = "GIF";
            this.chkGif.UseVisualStyleBackColor = true;
            // 
            // chkJpeg
            // 
            this.chkJpeg.AutoSize = true;
            this.chkJpeg.Checked = true;
            this.chkJpeg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJpeg.Enabled = false;
            this.chkJpeg.Location = new System.Drawing.Point(116, 94);
            this.chkJpeg.Name = "chkJpeg";
            this.chkJpeg.Size = new System.Drawing.Size(78, 17);
            this.chkJpeg.TabIndex = 5;
            this.chkJpeg.Tag = ".jpg|.jpeg";
            this.chkJpeg.Text = "JPG/JPEG";
            this.chkJpeg.UseVisualStyleBackColor = true;
            // 
            // chkPng
            // 
            this.chkPng.AutoSize = true;
            this.chkPng.Checked = true;
            this.chkPng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPng.Enabled = false;
            this.chkPng.Location = new System.Drawing.Point(116, 71);
            this.chkPng.Name = "chkPng";
            this.chkPng.Size = new System.Drawing.Size(49, 17);
            this.chkPng.TabIndex = 4;
            this.chkPng.Tag = ".png";
            this.chkPng.Text = "PNG";
            this.chkPng.UseVisualStyleBackColor = true;
            // 
            // chkXml
            // 
            this.chkXml.AutoSize = true;
            this.chkXml.Checked = true;
            this.chkXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXml.Enabled = false;
            this.chkXml.Location = new System.Drawing.Point(116, 47);
            this.chkXml.Name = "chkXml";
            this.chkXml.Size = new System.Drawing.Size(48, 17);
            this.chkXml.TabIndex = 3;
            this.chkXml.Tag = ".xml";
            this.chkXml.Text = "XML";
            this.chkXml.UseVisualStyleBackColor = true;
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Checked = true;
            this.chkJavaScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJavaScript.Enabled = false;
            this.chkJavaScript.Location = new System.Drawing.Point(6, 94);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(38, 17);
            this.chkJavaScript.TabIndex = 2;
            this.chkJavaScript.Tag = ".js|.json";
            this.chkJavaScript.Text = "JS";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Checked = true;
            this.chkCss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCss.Enabled = false;
            this.chkCss.Location = new System.Drawing.Point(6, 71);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(47, 17);
            this.chkCss.TabIndex = 1;
            this.chkCss.Tag = ".css";
            this.chkCss.Text = "CSS";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Checked = true;
            this.chkHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHtml.Enabled = false;
            this.chkHtml.Location = new System.Drawing.Point(6, 47);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(56, 17);
            this.chkHtml.TabIndex = 0;
            this.chkHtml.Tag = ".html|.htm";
            this.chkHtml.Text = "HTML";
            this.chkHtml.UseVisualStyleBackColor = true;
            // 
            // chkSvg
            // 
            this.chkSvg.AutoSize = true;
            this.chkSvg.Checked = true;
            this.chkSvg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSvg.Enabled = false;
            this.chkSvg.Location = new System.Drawing.Point(338, 71);
            this.chkSvg.Name = "chkSvg";
            this.chkSvg.Size = new System.Drawing.Size(48, 17);
            this.chkSvg.TabIndex = 11;
            this.chkSvg.Tag = ".svg";
            this.chkSvg.Text = "SVG";
            this.chkSvg.UseVisualStyleBackColor = true;
            // 
            // chkResx
            // 
            this.chkResx.AutoSize = true;
            this.chkResx.Checked = true;
            this.chkResx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResx.Enabled = false;
            this.chkResx.Location = new System.Drawing.Point(338, 94);
            this.chkResx.Name = "chkResx";
            this.chkResx.Size = new System.Drawing.Size(55, 17);
            this.chkResx.TabIndex = 12;
            this.chkResx.Tag = ".resx";
            this.chkResx.Text = "RESX";
            this.chkResx.UseVisualStyleBackColor = true;
            // 
            // WebResourceTypePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "WebResourceTypePicker";
            this.Size = new System.Drawing.Size(404, 122);
            this.Load += new System.EventHandler(this.WebResourceTypePicker_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkIco;
        private System.Windows.Forms.CheckBox chkXsl;
        private System.Windows.Forms.CheckBox chkXap;
        private System.Windows.Forms.CheckBox chkGif;
        private System.Windows.Forms.CheckBox chkJpeg;
        private System.Windows.Forms.CheckBox chkPng;
        private System.Windows.Forms.CheckBox chkXml;
        private System.Windows.Forms.CheckBox chkJavaScript;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.CheckBox chkHtml;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkResx;
        private System.Windows.Forms.CheckBox chkSvg;
    }
}
