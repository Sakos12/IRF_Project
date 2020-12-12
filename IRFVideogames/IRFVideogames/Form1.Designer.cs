﻿namespace IRFVideogames
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
            this.VideogameDataSet = new System.Data.DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.cím = new System.Windows.Forms.Label();
            this.controller2 = new IRFVideogames.Entities.Controller();
            this.controller1 = new IRFVideogames.Entities.Controller();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideogameDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VideogameDataSet
            // 
            this.VideogameDataSet.DataSetName = "VideogameDataSet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(589, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export to csv";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cím
            // 
            this.cím.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cím.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cím.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cím.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cím.Location = new System.Drawing.Point(147, 33);
            this.cím.Name = "cím";
            this.cím.Size = new System.Drawing.Size(1061, 164);
            this.cím.TabIndex = 2;
            this.cím.Text = "Ez a program a videójátékpiacon végzett saját kutatásomból alkotott adatbázis egy" +
    " részét hivatásos bemutatni!";
            this.cím.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controller2
            // 
            this.controller2.Image = global::IRFVideogames.Properties.Resources.list2;
            this.controller2.Location = new System.Drawing.Point(998, 416);
            this.controller2.Name = "controller2";
            this.controller2.Size = new System.Drawing.Size(200, 200);
            this.controller2.TabIndex = 6;
            this.controller2.UseVisualStyleBackColor = true;
            this.controller2.Click += new System.EventHandler(this.controller2_Click);
            // 
            // controller1
            // 
            this.controller1.Image = global::IRFVideogames.Properties.Resources.playstation;
            this.controller1.Location = new System.Drawing.Point(166, 441);
            this.controller1.Name = "controller1";
            this.controller1.Size = new System.Drawing.Size(200, 200);
            this.controller1.TabIndex = 5;
            this.controller1.UseVisualStyleBackColor = true;
            this.controller1.Click += new System.EventHandler(this.controller1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(67, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 137);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kattints ide, ha csupán meg szeretnéd nézni a gyűjteményt minden módosítás, vagy " +
    "szűrés nélkül!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(889, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 137);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kattints ide, ha szeretnéd megjelenési évek, illetve névszerint szűrni a videóját" +
    "ékokat!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1419, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controller2);
            this.Controls.Add(this.controller1);
            this.Controls.Add(this.cím);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.VideogameDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet VideogameDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cím;
        private Entities.Controller controller1;
        private Entities.Controller controller2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

