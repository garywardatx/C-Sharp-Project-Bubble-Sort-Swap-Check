namespace IT325_SortAlgorithms_GEW {
    partial class FormSortAlgorithms {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelBeforeSort = new System.Windows.Forms.Label();
            this.listBoxBeforeSort = new System.Windows.Forms.ListBox();
            this.labelAfterSort = new System.Windows.Forms.Label();
            this.listBoxAfterSort = new System.Windows.Forms.ListBox();
            this.groupBoxBubbleSort = new System.Windows.Forms.GroupBox();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.buttonBubbleInline = new System.Windows.Forms.Button();
            this.buttonBubbleSortClass = new System.Windows.Forms.Button();
            this.buttonBubbleSortGeneric = new System.Windows.Forms.Button();
            this.groupBoxBubbleSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBeforeSort
            // 
            this.labelBeforeSort.AutoSize = true;
            this.labelBeforeSort.Location = new System.Drawing.Point(13, 13);
            this.labelBeforeSort.Name = "labelBeforeSort";
            this.labelBeforeSort.Size = new System.Drawing.Size(63, 13);
            this.labelBeforeSort.TabIndex = 0;
            this.labelBeforeSort.Text = "Before Sort:";
            // 
            // listBoxBeforeSort
            // 
            this.listBoxBeforeSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBeforeSort.FormattingEnabled = true;
            this.listBoxBeforeSort.Location = new System.Drawing.Point(16, 30);
            this.listBoxBeforeSort.Name = "listBoxBeforeSort";
            this.listBoxBeforeSort.Size = new System.Drawing.Size(216, 407);
            this.listBoxBeforeSort.TabIndex = 1;
            // 
            // labelAfterSort
            // 
            this.labelAfterSort.AutoSize = true;
            this.labelAfterSort.Location = new System.Drawing.Point(256, 13);
            this.labelAfterSort.Name = "labelAfterSort";
            this.labelAfterSort.Size = new System.Drawing.Size(54, 13);
            this.labelAfterSort.TabIndex = 2;
            this.labelAfterSort.Text = "After Sort:";
            // 
            // listBoxAfterSort
            // 
            this.listBoxAfterSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAfterSort.FormattingEnabled = true;
            this.listBoxAfterSort.Location = new System.Drawing.Point(259, 30);
            this.listBoxAfterSort.Name = "listBoxAfterSort";
            this.listBoxAfterSort.Size = new System.Drawing.Size(216, 407);
            this.listBoxAfterSort.TabIndex = 3;
            // 
            // groupBoxBubbleSort
            // 
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleSortGeneric);
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleSortClass);
            this.groupBoxBubbleSort.Controls.Add(this.buttonFunction);
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleInline);
            this.groupBoxBubbleSort.Location = new System.Drawing.Point(509, 30);
            this.groupBoxBubbleSort.Name = "groupBoxBubbleSort";
            this.groupBoxBubbleSort.Size = new System.Drawing.Size(200, 160);
            this.groupBoxBubbleSort.TabIndex = 6;
            this.groupBoxBubbleSort.TabStop = false;
            this.groupBoxBubbleSort.Text = "Bubble Sort";
            // 
            // buttonFunction
            // 
            this.buttonFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFunction.Location = new System.Drawing.Point(63, 53);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(75, 23);
            this.buttonFunction.TabIndex = 7;
            this.buttonFunction.Text = "Function";
            this.buttonFunction.UseVisualStyleBackColor = true;
            this.buttonFunction.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonBubbleInline
            // 
            this.buttonBubbleInline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBubbleInline.Location = new System.Drawing.Point(63, 24);
            this.buttonBubbleInline.Name = "buttonBubbleInline";
            this.buttonBubbleInline.Size = new System.Drawing.Size(75, 23);
            this.buttonBubbleInline.TabIndex = 6;
            this.buttonBubbleInline.Text = "Inline";
            this.buttonBubbleInline.UseVisualStyleBackColor = true;
            this.buttonBubbleInline.Click += new System.EventHandler(this.buttonBubbleInline_Click);
            // 
            // buttonBubbleSortClass
            // 
            this.buttonBubbleSortClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBubbleSortClass.Location = new System.Drawing.Point(63, 82);
            this.buttonBubbleSortClass.Name = "buttonBubbleSortClass";
            this.buttonBubbleSortClass.Size = new System.Drawing.Size(75, 23);
            this.buttonBubbleSortClass.TabIndex = 8;
            this.buttonBubbleSortClass.Text = "Integer";
            this.buttonBubbleSortClass.UseVisualStyleBackColor = true;
            this.buttonBubbleSortClass.Click += new System.EventHandler(this.buttonBubbleSortClass_Click);
            // 
            // buttonBubbleSortGeneric
            // 
            this.buttonBubbleSortGeneric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBubbleSortGeneric.Location = new System.Drawing.Point(63, 111);
            this.buttonBubbleSortGeneric.Name = "buttonBubbleSortGeneric";
            this.buttonBubbleSortGeneric.Size = new System.Drawing.Size(75, 23);
            this.buttonBubbleSortGeneric.TabIndex = 9;
            this.buttonBubbleSortGeneric.Text = "Generic";
            this.buttonBubbleSortGeneric.UseVisualStyleBackColor = true;
            this.buttonBubbleSortGeneric.Click += new System.EventHandler(this.buttonBubbleSortGeneric_Click);
            // 
            // FormSortAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxBubbleSort);
            this.Controls.Add(this.listBoxAfterSort);
            this.Controls.Add(this.labelAfterSort);
            this.Controls.Add(this.listBoxBeforeSort);
            this.Controls.Add(this.labelBeforeSort);
            this.Name = "FormSortAlgorithms";
            this.Text = "Sort Algorithms";
            this.groupBoxBubbleSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBeforeSort;
        private System.Windows.Forms.ListBox listBoxBeforeSort;
        private System.Windows.Forms.Label labelAfterSort;
        private System.Windows.Forms.ListBox listBoxAfterSort;
        private System.Windows.Forms.GroupBox groupBoxBubbleSort;
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.Button buttonBubbleInline;
        private System.Windows.Forms.Button buttonBubbleSortClass;
        private System.Windows.Forms.Button buttonBubbleSortGeneric;
    }
}

