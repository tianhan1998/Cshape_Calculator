namespace 计算器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.pow3 = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.pow2 = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.memoryStack = new System.Windows.Forms.TextBox();
            this.op = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.载入记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alldisplay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.display.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.display.HideSelection = false;
            this.display.Location = new System.Drawing.Point(26, 65);
            this.display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(584, 51);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Display_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(123, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 76);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(213, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 76);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(302, 494);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 76);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(123, 392);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 76);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(213, 392);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 76);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(302, 392);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 76);
            this.button6.TabIndex = 4;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.AutoSize = true;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(123, 290);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 76);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.AutoSize = true;
            this.button8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(213, 290);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 76);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.AutoSize = true;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(302, 290);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(71, 76);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // point
            // 
            this.point.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.point.Location = new System.Drawing.Point(302, 592);
            this.point.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(71, 76);
            this.point.TabIndex = 12;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Point_Click);
            // 
            // button0
            // 
            this.button0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button0.AutoSize = true;
            this.button0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button0.Location = new System.Drawing.Point(213, 592);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 76);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // equals
            // 
            this.equals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equals.AutoSize = true;
            this.equals.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equals.Location = new System.Drawing.Point(397, 592);
            this.equals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(71, 76);
            this.equals.TabIndex = 10;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // divide
            // 
            this.divide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divide.AutoSize = true;
            this.divide.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divide.Location = new System.Drawing.Point(397, 192);
            this.divide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(71, 76);
            this.divide.TabIndex = 16;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // plus
            // 
            this.plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plus.Location = new System.Drawing.Point(397, 494);
            this.plus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(71, 76);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // minus
            // 
            this.minus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minus.AutoSize = true;
            this.minus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minus.Location = new System.Drawing.Point(397, 392);
            this.minus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(71, 76);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // multiply
            // 
            this.multiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiply.AutoSize = true;
            this.multiply.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.multiply.Location = new System.Drawing.Point(397, 290);
            this.multiply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(71, 76);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // pow3
            // 
            this.pow3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pow3.AutoSize = true;
            this.pow3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pow3.Location = new System.Drawing.Point(26, 592);
            this.pow3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pow3.Name = "pow3";
            this.pow3.Size = new System.Drawing.Size(71, 76);
            this.pow3.TabIndex = 20;
            this.pow3.Text = "x3";
            this.pow3.UseVisualStyleBackColor = true;
            // 
            // mod
            // 
            this.mod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mod.AutoSize = true;
            this.mod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mod.Location = new System.Drawing.Point(26, 290);
            this.mod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(71, 76);
            this.mod.TabIndex = 19;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            // 
            // sqrt
            // 
            this.sqrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqrt.AutoSize = true;
            this.sqrt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqrt.Location = new System.Drawing.Point(26, 392);
            this.sqrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(71, 76);
            this.sqrt.TabIndex = 18;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            // 
            // pow2
            // 
            this.pow2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pow2.AutoSize = true;
            this.pow2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pow2.Location = new System.Drawing.Point(26, 494);
            this.pow2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pow2.Name = "pow2";
            this.pow2.Size = new System.Drawing.Size(71, 76);
            this.pow2.TabIndex = 17;
            this.pow2.Text = "x2";
            this.pow2.UseVisualStyleBackColor = true;
            // 
            // backspace
            // 
            this.backspace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backspace.AutoSize = true;
            this.backspace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backspace.Location = new System.Drawing.Point(302, 192);
            this.backspace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(71, 76);
            this.backspace.TabIndex = 21;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.clear.Location = new System.Drawing.Point(26, 192);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(71, 76);
            this.clear.TabIndex = 22;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // right
            // 
            this.right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.right.AutoSize = true;
            this.right.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.right.Location = new System.Drawing.Point(213, 192);
            this.right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(71, 76);
            this.right.TabIndex = 24;
            this.right.Text = ")";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.Right_Click);
            // 
            // left
            // 
            this.left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.left.AutoSize = true;
            this.left.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.left.Location = new System.Drawing.Point(123, 192);
            this.left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(71, 76);
            this.left.TabIndex = 23;
            this.left.Text = "(";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.Left_Click);
            // 
            // negative
            // 
            this.negative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.negative.AutoSize = true;
            this.negative.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.negative.Location = new System.Drawing.Point(123, 592);
            this.negative.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(71, 76);
            this.negative.TabIndex = 25;
            this.negative.Text = "±";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.Negative_Click);
            // 
            // memoryStack
            // 
            this.memoryStack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memoryStack.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.memoryStack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.memoryStack.HideSelection = false;
            this.memoryStack.Location = new System.Drawing.Point(500, 192);
            this.memoryStack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memoryStack.Multiline = true;
            this.memoryStack.Name = "memoryStack";
            this.memoryStack.ReadOnly = true;
            this.memoryStack.Size = new System.Drawing.Size(116, 474);
            this.memoryStack.TabIndex = 26;
            this.memoryStack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MemoryStack_MouseDown);
            // 
            // op
            // 
            this.op.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.op.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.op.HideSelection = false;
            this.op.Location = new System.Drawing.Point(564, 126);
            this.op.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.op.Multiline = true;
            this.op.Name = "op";
            this.op.ReadOnly = true;
            this.op.Size = new System.Drawing.Size(52, 56);
            this.op.TabIndex = 27;
            this.op.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Op_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 25);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存记录ToolStripMenuItem,
            this.载入记录ToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存记录ToolStripMenuItem
            // 
            this.保存记录ToolStripMenuItem.Name = "保存记录ToolStripMenuItem";
            this.保存记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存记录ToolStripMenuItem.Text = "保存记录";
            // 
            // 载入记录ToolStripMenuItem
            // 
            this.载入记录ToolStripMenuItem.Name = "载入记录ToolStripMenuItem";
            this.载入记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.载入记录ToolStripMenuItem.Text = "载入记录";
            // 
            // alldisplay
            // 
            this.alldisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alldisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alldisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alldisplay.HideSelection = false;
            this.alldisplay.Location = new System.Drawing.Point(26, 43);
            this.alldisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alldisplay.Multiline = true;
            this.alldisplay.Name = "alldisplay";
            this.alldisplay.ReadOnly = true;
            this.alldisplay.Size = new System.Drawing.Size(584, 22);
            this.alldisplay.TabIndex = 29;
            this.alldisplay.TabStop = false;
            this.alldisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 91);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 694);
            this.Controls.Add(this.alldisplay);
            this.Controls.Add(this.op);
            this.Controls.Add(this.memoryStack);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.pow3);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.pow2);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.point);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button pow3;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button pow2;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.TextBox memoryStack;
        private System.Windows.Forms.TextBox op;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 载入记录ToolStripMenuItem;
        private System.Windows.Forms.TextBox alldisplay;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

