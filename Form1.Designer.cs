namespace EpicGameUploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uploadToolSelectBt = new System.Windows.Forms.Button();
            this.tBoxUploadTool = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadAppSelectBt = new System.Windows.Forms.Button();
            this.uploadDirectoryTbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxOrganizationId = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxProductId = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxArtifactId = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxBPTClientId = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxBPTClientSecret = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxCloudDir = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxBuildVersion = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxAppArgs = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxIgnore = new System.Windows.Forms.TextBox();
            this.UploadBt = new System.Windows.Forms.Button();
            this.Win64Toggle = new System.Windows.Forms.RadioButton();
            this.MacOSToggle = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(992, 440);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.uploadToolSelectBt);
            this.panel3.Controls.Add(this.tBoxUploadTool);
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 36);
            this.panel3.TabIndex = 4;
            // 
            // uploadToolSelectBt
            // 
            this.uploadToolSelectBt.Location = new System.Drawing.Point(852, 4);
            this.uploadToolSelectBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadToolSelectBt.Name = "uploadToolSelectBt";
            this.uploadToolSelectBt.Size = new System.Drawing.Size(100, 29);
            this.uploadToolSelectBt.TabIndex = 2;
            this.uploadToolSelectBt.Text = "选择";
            this.uploadToolSelectBt.UseVisualStyleBackColor = true;
            this.uploadToolSelectBt.Click += new System.EventHandler(this.uploadToolSelectBt_Click);
            // 
            // tBoxUploadTool
            // 
            this.tBoxUploadTool.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxUploadTool.Location = new System.Drawing.Point(177, 4);
            this.tBoxUploadTool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxUploadTool.Name = "tBoxUploadTool";
            this.tBoxUploadTool.Size = new System.Drawing.Size(651, 27);
            this.tBoxUploadTool.TabIndex = 1;
            this.tBoxUploadTool.TextChanged += new System.EventHandler(this.tBoxUploadTool_TextChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.Location = new System.Drawing.Point(8, 10);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(107, 18);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "上传工具exe";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uploadAppSelectBt);
            this.panel1.Controls.Add(this.uploadDirectoryTbox);
            this.panel1.Location = new System.Drawing.Point(4, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择上传游戏exe";
            // 
            // uploadAppSelectBt
            // 
            this.uploadAppSelectBt.Location = new System.Drawing.Point(852, 4);
            this.uploadAppSelectBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadAppSelectBt.Name = "uploadAppSelectBt";
            this.uploadAppSelectBt.Size = new System.Drawing.Size(100, 29);
            this.uploadAppSelectBt.TabIndex = 2;
            this.uploadAppSelectBt.Text = "选择";
            this.uploadAppSelectBt.UseVisualStyleBackColor = true;
            this.uploadAppSelectBt.Click += new System.EventHandler(this.uploadAppSelectBt_Click);
            // 
            // uploadAppTbox
            // 
            this.uploadDirectoryTbox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploadDirectoryTbox.Location = new System.Drawing.Point(177, 4);
            this.uploadDirectoryTbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadDirectoryTbox.Name = "uploadAppTbox";
            this.uploadDirectoryTbox.Size = new System.Drawing.Size(651, 27);
            this.uploadDirectoryTbox.TabIndex = 1;
            this.uploadDirectoryTbox.TextChanged += new System.EventHandler(this.uploadDirectoryTbox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tBoxOrganizationId);
            this.panel2.Location = new System.Drawing.Point(4, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 36);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "OrganizationId";
            // 
            // tBoxOrganizationId
            // 
            this.tBoxOrganizationId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxOrganizationId.Location = new System.Drawing.Point(177, 4);
            this.tBoxOrganizationId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxOrganizationId.Name = "tBoxOrganizationId";
            this.tBoxOrganizationId.Size = new System.Drawing.Size(651, 27);
            this.tBoxOrganizationId.TabIndex = 1;
            this.tBoxOrganizationId.TextChanged += new System.EventHandler(this.tBoxOrganizationId_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tBoxProductId);
            this.panel4.Location = new System.Drawing.Point(4, 136);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 36);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProductId";
            // 
            // tBoxProductId
            // 
            this.tBoxProductId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxProductId.Location = new System.Drawing.Point(177, 4);
            this.tBoxProductId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxProductId.Name = "tBoxProductId";
            this.tBoxProductId.Size = new System.Drawing.Size(651, 27);
            this.tBoxProductId.TabIndex = 1;
            this.tBoxProductId.TextChanged += new System.EventHandler(this.tBoxProductId_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.tBoxArtifactId);
            this.panel5.Location = new System.Drawing.Point(4, 180);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(984, 36);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "ArtifactId";
            // 
            // tBoxArtifactId
            // 
            this.tBoxArtifactId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxArtifactId.Location = new System.Drawing.Point(177, 4);
            this.tBoxArtifactId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxArtifactId.Name = "tBoxArtifactId";
            this.tBoxArtifactId.Size = new System.Drawing.Size(651, 27);
            this.tBoxArtifactId.TabIndex = 1;
            this.tBoxArtifactId.TextChanged += new System.EventHandler(this.tBoxArtifactId_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.tBoxBPTClientId);
            this.panel6.Location = new System.Drawing.Point(4, 224);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(984, 36);
            this.panel6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "BPTClientId";
            // 
            // tBoxBPTClientId
            // 
            this.tBoxBPTClientId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxBPTClientId.Location = new System.Drawing.Point(177, 4);
            this.tBoxBPTClientId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxBPTClientId.Name = "tBoxBPTClientId";
            this.tBoxBPTClientId.Size = new System.Drawing.Size(651, 27);
            this.tBoxBPTClientId.TabIndex = 1;
            this.tBoxBPTClientId.TextChanged += new System.EventHandler(this.tBoxBPTClientId_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.tBoxBPTClientSecret);
            this.panel7.Location = new System.Drawing.Point(4, 268);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(984, 36);
            this.panel7.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "BPTClientSecret";
            // 
            // tBoxBPTClientSecret
            // 
            this.tBoxBPTClientSecret.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxBPTClientSecret.Location = new System.Drawing.Point(177, 4);
            this.tBoxBPTClientSecret.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxBPTClientSecret.Name = "tBoxBPTClientSecret";
            this.tBoxBPTClientSecret.Size = new System.Drawing.Size(651, 27);
            this.tBoxBPTClientSecret.TabIndex = 1;
            this.tBoxBPTClientSecret.TextChanged += new System.EventHandler(this.tBoxBPTClientSecret_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.tBoxCloudDir);
            this.panel8.Location = new System.Drawing.Point(4, 312);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(984, 36);
            this.panel8.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "CloudDir";
            // 
            // tBoxCloudDir
            // 
            this.tBoxCloudDir.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxCloudDir.Location = new System.Drawing.Point(177, 4);
            this.tBoxCloudDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxCloudDir.Name = "tBoxCloudDir";
            this.tBoxCloudDir.Size = new System.Drawing.Size(651, 27);
            this.tBoxCloudDir.TabIndex = 1;
            this.tBoxCloudDir.TextChanged += new System.EventHandler(this.tBoxCloudDir_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.tBoxBuildVersion);
            this.panel9.Location = new System.Drawing.Point(4, 356);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(984, 36);
            this.panel9.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "BuildVersion";
            // 
            // tBoxBuildVersion
            // 
            this.tBoxBuildVersion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxBuildVersion.Location = new System.Drawing.Point(177, 4);
            this.tBoxBuildVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxBuildVersion.Name = "tBoxBuildVersion";
            this.tBoxBuildVersion.Size = new System.Drawing.Size(651, 27);
            this.tBoxBuildVersion.TabIndex = 1;
            this.tBoxBuildVersion.TextChanged += new System.EventHandler(this.tBoxBuildVersion_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.tBoxAppArgs);
            this.panel10.Location = new System.Drawing.Point(4, 400);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(984, 36);
            this.panel10.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "AppArgs";
            // 
            // tBoxAppArgs
            // 
            this.tBoxAppArgs.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxAppArgs.Location = new System.Drawing.Point(177, 4);
            this.tBoxAppArgs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxAppArgs.Name = "tBoxAppArgs";
            this.tBoxAppArgs.Size = new System.Drawing.Size(651, 27);
            this.tBoxAppArgs.TabIndex = 1;
            this.tBoxAppArgs.TextChanged += new System.EventHandler(this.tBoxAppArgs_TextChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LightGreen;
            this.refreshButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refreshButton.Location = new System.Drawing.Point(869, 460);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(160, 38);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(292, 532);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(422, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "忽略上传的文件夹或文件(相对于游戏.exe所在目录)";
            // 
            // tBoxIgnore
            // 
            this.tBoxIgnore.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxIgnore.Location = new System.Drawing.Point(41, 554);
            this.tBoxIgnore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxIgnore.Multiline = true;
            this.tBoxIgnore.Name = "tBoxIgnore";
            this.tBoxIgnore.Size = new System.Drawing.Size(987, 207);
            this.tBoxIgnore.TabIndex = 5;
            this.tBoxIgnore.TextChanged += new System.EventHandler(this.tBoxIgnore_TextChanged);
            // 
            // UploadBt
            // 
            this.UploadBt.BackColor = System.Drawing.Color.LimeGreen;
            this.UploadBt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UploadBt.Location = new System.Drawing.Point(397, 784);
            this.UploadBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UploadBt.Name = "UploadBt";
            this.UploadBt.Size = new System.Drawing.Size(224, 62);
            this.UploadBt.TabIndex = 6;
            this.UploadBt.Text = "开始上传";
            this.UploadBt.UseVisualStyleBackColor = false;
            this.UploadBt.Click += new System.EventHandler(this.UploadBt_Click);
            // 
            // Win64Toggle
            // 
            this.Win64Toggle.AutoSize = true;
            this.Win64Toggle.Location = new System.Drawing.Point(684, 471);
            this.Win64Toggle.Name = "Win64Toggle";
            this.Win64Toggle.Size = new System.Drawing.Size(68, 19);
            this.Win64Toggle.TabIndex = 7;
            this.Win64Toggle.TabStop = true;
            this.Win64Toggle.Text = "Win64";
            this.Win64Toggle.UseVisualStyleBackColor = true;
            // 
            // MacOSToggle
            // 
            this.MacOSToggle.AutoSize = true;
            this.MacOSToggle.Location = new System.Drawing.Point(524, 471);
            this.MacOSToggle.Name = "MacOSToggle";
            this.MacOSToggle.Size = new System.Drawing.Size(68, 19);
            this.MacOSToggle.TabIndex = 8;
            this.MacOSToggle.TabStop = true;
            this.MacOSToggle.Text = "MacOS";
            this.MacOSToggle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 861);
            this.Controls.Add(this.MacOSToggle);
            this.Controls.Add(this.Win64Toggle);
            this.Controls.Add(this.UploadBt);
            this.Controls.Add(this.tBoxIgnore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "EpicGameUploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uploadAppSelectBt;
        private System.Windows.Forms.TextBox uploadDirectoryTbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button uploadToolSelectBt;
        private System.Windows.Forms.TextBox tBoxUploadTool;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxOrganizationId;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxProductId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxArtifactId;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxBPTClientId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxBPTClientSecret;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxCloudDir;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxBuildVersion;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxAppArgs;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBoxIgnore;
        private System.Windows.Forms.Button UploadBt;
        private System.Windows.Forms.RadioButton Win64Toggle;
        private System.Windows.Forms.RadioButton MacOSToggle;
    }
}

