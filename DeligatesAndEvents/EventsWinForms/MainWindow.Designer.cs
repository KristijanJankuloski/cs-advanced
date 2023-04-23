namespace EventsWinForms
{
    partial class MainWindow
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
            btnSave = new Button();
            label = new Label();
            txtSomething = new TextBox();
            lblResult = new Label();
            label2 = new Label();
            lblTimesClicked = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(206, 27);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(94, 15);
            label.TabIndex = 1;
            label.Text = "Enter something";
            // 
            // txtSomething
            // 
            txtSomething.Location = new Point(12, 27);
            txtSomething.Name = "txtSomething";
            txtSomething.Size = new Size(178, 23);
            txtSomething.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(12, 71);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 4;
            label2.Text = "Times Clicked";
            // 
            // lblTimesClicked
            // 
            lblTimesClicked.AutoSize = true;
            lblTimesClicked.Location = new Point(98, 131);
            lblTimesClicked.Name = "lblTimesClicked";
            lblTimesClicked.Size = new Size(13, 15);
            lblTimesClicked.TabIndex = 5;
            lblTimesClicked.Text = "0";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTimesClicked);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(txtSomething);
            Controls.Add(label);
            Controls.Add(btnSave);
            Name = "MainWindow";
            Text = "Click";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label;
        private TextBox txtSomething;
        private Label lblResult;
        private Label label2;
        private Label lblTimesClicked;
    }
}