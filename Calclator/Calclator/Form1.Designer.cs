﻿namespace Calclator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonZeroth = new System.Windows.Forms.Button();
            this.buttonNineth = new System.Windows.Forms.Button();
            this.buttonEighth = new System.Windows.Forms.Button();
            this.buttonSeventh = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonFourth = new System.Windows.Forms.Button();
            this.buttonFifth = new System.Windows.Forms.Button();
            this.buttonSixth = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.calcWindow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(57, 155);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(35, 35);
            this.buttonSecond.TabIndex = 2;
            this.buttonSecond.Text = "2";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(157, 208);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(35, 34);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(157, 155);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(35, 35);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(207, 155);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(35, 87);
            this.buttonEqual.TabIndex = 6;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(157, 101);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(35, 36);
            this.buttonMul.TabIndex = 7;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(107, 155);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(35, 35);
            this.buttonThree.TabIndex = 8;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonZeroth
            // 
            this.buttonZeroth.Location = new System.Drawing.Point(7, 208);
            this.buttonZeroth.Name = "buttonZeroth";
            this.buttonZeroth.Size = new System.Drawing.Size(85, 34);
            this.buttonZeroth.TabIndex = 9;
            this.buttonZeroth.Text = "0";
            this.buttonZeroth.UseVisualStyleBackColor = true;
            this.buttonZeroth.Click += new System.EventHandler(this.ButtonZeroth_Click_1);
            // 
            // buttonNineth
            // 
            this.buttonNineth.Location = new System.Drawing.Point(107, 49);
            this.buttonNineth.Name = "buttonNineth";
            this.buttonNineth.Size = new System.Drawing.Size(35, 34);
            this.buttonNineth.TabIndex = 10;
            this.buttonNineth.Text = "9";
            this.buttonNineth.UseVisualStyleBackColor = true;
            this.buttonNineth.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonEighth
            // 
            this.buttonEighth.Location = new System.Drawing.Point(56, 49);
            this.buttonEighth.Name = "buttonEighth";
            this.buttonEighth.Size = new System.Drawing.Size(35, 34);
            this.buttonEighth.TabIndex = 11;
            this.buttonEighth.Text = "8";
            this.buttonEighth.UseVisualStyleBackColor = true;
            this.buttonEighth.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonSeventh
            // 
            this.buttonSeventh.Location = new System.Drawing.Point(8, 49);
            this.buttonSeventh.Name = "buttonSeventh";
            this.buttonSeventh.Size = new System.Drawing.Size(34, 34);
            this.buttonSeventh.TabIndex = 12;
            this.buttonSeventh.Text = "7";
            this.buttonSeventh.UseVisualStyleBackColor = true;
            this.buttonSeventh.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(7, 155);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(34, 35);
            this.buttonFirst.TabIndex = 13;
            this.buttonFirst.Text = "1";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonFourth
            // 
            this.buttonFourth.Location = new System.Drawing.Point(7, 101);
            this.buttonFourth.Name = "buttonFourth";
            this.buttonFourth.Size = new System.Drawing.Size(35, 36);
            this.buttonFourth.TabIndex = 14;
            this.buttonFourth.Text = "4";
            this.buttonFourth.UseVisualStyleBackColor = true;
            this.buttonFourth.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonFifth
            // 
            this.buttonFifth.Location = new System.Drawing.Point(57, 101);
            this.buttonFifth.Name = "buttonFifth";
            this.buttonFifth.Size = new System.Drawing.Size(35, 36);
            this.buttonFifth.TabIndex = 15;
            this.buttonFifth.Text = "5";
            this.buttonFifth.UseVisualStyleBackColor = true;
            this.buttonFifth.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonSixth
            // 
            this.buttonSixth.Location = new System.Drawing.Point(107, 101);
            this.buttonSixth.Name = "buttonSixth";
            this.buttonSixth.Size = new System.Drawing.Size(35, 36);
            this.buttonSixth.TabIndex = 16;
            this.buttonSixth.Text = "6";
            this.buttonSixth.UseVisualStyleBackColor = true;
            this.buttonSixth.Click += new System.EventHandler(this.ButtonNumber_Click_1);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(157, 49);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(35, 34);
            this.buttonDiv.TabIndex = 3;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(207, 49);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(35, 34);
            this.buttonCE.TabIndex = 17;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(207, 101);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(35, 36);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "→";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // calcWindow
            // 
            this.calcWindow.BackColor = System.Drawing.Color.White;
            this.calcWindow.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calcWindow.Location = new System.Drawing.Point(7, 12);
            this.calcWindow.Name = "calcWindow";
            this.calcWindow.ReadOnly = true;
            this.calcWindow.Size = new System.Drawing.Size(235, 28);
            this.calcWindow.TabIndex = 19;
            this.calcWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 258);
            this.Controls.Add(this.calcWindow);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonSixth);
            this.Controls.Add(this.buttonFifth);
            this.Controls.Add(this.buttonFourth);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonSeventh);
            this.Controls.Add(this.buttonEighth);
            this.Controls.Add(this.buttonNineth);
            this.Controls.Add(this.buttonZeroth);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonZeroth;
        private System.Windows.Forms.Button buttonNineth;
        private System.Windows.Forms.Button buttonEighth;
        private System.Windows.Forms.Button buttonSeventh;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonFourth;
        private System.Windows.Forms.Button buttonFifth;
        private System.Windows.Forms.Button buttonSixth;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox calcWindow;
    }
}

