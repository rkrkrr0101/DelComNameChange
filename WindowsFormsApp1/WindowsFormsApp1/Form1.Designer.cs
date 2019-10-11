namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.parnamebox = new System.Windows.Forms.TextBox();
            this.textcapBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.widthbox = new System.Windows.Forms.TextBox();
            this.topBox = new System.Windows.Forms.TextBox();
            this.leftbox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.taporderBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textcapcheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inctopBox = new System.Windows.Forms.TextBox();
            this.incleftBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.incnameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CompoBox = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.filenameBox);
            this.panel1.Controls.Add(this.pathBox);
            this.panel1.Controls.Add(this.CompoBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.incnameBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.inctopBox);
            this.panel1.Controls.Add(this.incleftBox);
            this.panel1.Controls.Add(this.parnamebox);
            this.panel1.Controls.Add(this.textcapBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.widthbox);
            this.panel1.Controls.Add(this.topBox);
            this.panel1.Controls.Add(this.leftbox);
            this.panel1.Controls.Add(this.heightBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.taporderBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textcapcheck);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(74, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1698, 1001);
            this.panel1.TabIndex = 0;
            // 
            // parnamebox
            // 
            this.parnamebox.Location = new System.Drawing.Point(689, 64);
            this.parnamebox.Name = "parnamebox";
            this.parnamebox.Size = new System.Drawing.Size(100, 35);
            this.parnamebox.TabIndex = 0;
            this.parnamebox.Text = "Panel1";
            // 
            // textcapBox
            // 
            this.textcapBox.Location = new System.Drawing.Point(337, 489);
            this.textcapBox.Name = "textcapBox";
            this.textcapBox.Size = new System.Drawing.Size(100, 35);
            this.textcapBox.TabIndex = 10;
            this.textcapBox.Text = "tred";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(377, 114);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 35);
            this.nameBox.TabIndex = 2;
            this.nameBox.Text = "abe";
            // 
            // widthbox
            // 
            this.widthbox.Location = new System.Drawing.Point(377, 389);
            this.widthbox.Name = "widthbox";
            this.widthbox.Size = new System.Drawing.Size(100, 35);
            this.widthbox.TabIndex = 8;
            this.widthbox.Text = "10";
            // 
            // topBox
            // 
            this.topBox.Location = new System.Drawing.Point(377, 325);
            this.topBox.Name = "topBox";
            this.topBox.Size = new System.Drawing.Size(100, 35);
            this.topBox.TabIndex = 6;
            this.topBox.Text = "40";
            // 
            // leftbox
            // 
            this.leftbox.Location = new System.Drawing.Point(377, 283);
            this.leftbox.Name = "leftbox";
            this.leftbox.Size = new System.Drawing.Size(100, 35);
            this.leftbox.TabIndex = 4;
            this.leftbox.Text = "30";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(379, 424);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 35);
            this.heightBox.TabIndex = 9;
            this.heightBox.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "부모컴포넌트";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1698, 39);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "새로 추가";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(52, 36);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "전체 항목 수";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "삭제";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "처음으로 이동";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "이전으로 이동";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "위치";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "현재 위치";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "다음으로 이동";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "마지막으로 이동";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // taporderBox
            // 
            this.taporderBox.Location = new System.Drawing.Point(751, 488);
            this.taporderBox.Name = "taporderBox";
            this.taporderBox.Size = new System.Drawing.Size(100, 35);
            this.taporderBox.TabIndex = 11;
            this.taporderBox.Text = "5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1329, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 101);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textcapcheck
            // 
            this.textcapcheck.AutoSize = true;
            this.textcapcheck.Location = new System.Drawing.Point(504, 495);
            this.textcapcheck.Name = "textcapcheck";
            this.textcapcheck.Size = new System.Drawing.Size(83, 28);
            this.textcapcheck.TabIndex = 7;
            this.textcapcheck.Text = "text";
            this.textcapcheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "top";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "text or caption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "height";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 930);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inctopBox
            // 
            this.inctopBox.Location = new System.Drawing.Point(566, 314);
            this.inctopBox.Name = "inctopBox";
            this.inctopBox.Size = new System.Drawing.Size(100, 35);
            this.inctopBox.TabIndex = 7;
            this.inctopBox.Text = "0";
            // 
            // incleftBox
            // 
            this.incleftBox.Location = new System.Drawing.Point(566, 272);
            this.incleftBox.Name = "incleftBox";
            this.incleftBox.Size = new System.Drawing.Size(100, 35);
            this.incleftBox.TabIndex = 5;
            this.incleftBox.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(644, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "taporder";
            // 
            // incnameBox
            // 
            this.incnameBox.Location = new System.Drawing.Point(554, 114);
            this.incnameBox.Name = "incnameBox";
            this.incnameBox.Size = new System.Drawing.Size(100, 35);
            this.incnameBox.TabIndex = 3;
            this.incnameBox.Text = "123";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(937, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "컴포넌트이름";
            // 
            // CompoBox
            // 
            this.CompoBox.Location = new System.Drawing.Point(1096, 72);
            this.CompoBox.Name = "CompoBox";
            this.CompoBox.Size = new System.Drawing.Size(100, 35);
            this.CompoBox.TabIndex = 1;
            this.CompoBox.Text = "TLabel";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(185, 790);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(100, 35);
            this.pathBox.TabIndex = 27;
            this.pathBox.Text = "C:\\";
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(487, 790);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(100, 35);
            this.filenameBox.TabIndex = 28;
            this.filenameBox.Text = "Unit1.dfm";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(1237, 765);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 35);
            this.numBox.TabIndex = 29;
            this.numBox.Text = "4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(939, 776);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1862, 1154);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form13";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox textcapcheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox taporderBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox parnamebox;
        private System.Windows.Forms.TextBox textcapBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox widthbox;
        private System.Windows.Forms.TextBox topBox;
        private System.Windows.Forms.TextBox leftbox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inctopBox;
        private System.Windows.Forms.TextBox incleftBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox incnameBox;
        private System.Windows.Forms.TextBox CompoBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label10;
    }
}

