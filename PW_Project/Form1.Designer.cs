
namespace PW_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_start = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label_progress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_activeThreads = new System.Windows.Forms.Label();
            this.label_activeThreadsHeader = new System.Windows.Forms.Label();
            this.label_scrollBarHeader = new System.Windows.Forms.Label();
            this.label_scrollVal = new System.Windows.Forms.Label();
            this.scrollBar_threads = new System.Windows.Forms.HScrollBar();
            this.label_timeHeader = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.picture_orlen_logo = new System.Windows.Forms.PictureBox();
            this.label_author = new System.Windows.Forms.Label();
            this.panel_preview = new System.Windows.Forms.Panel();
            this.panel_cashes = new System.Windows.Forms.Panel();
            this.labelbox_queues_header = new System.Windows.Forms.Label();
            this.label_cash_header = new System.Windows.Forms.Label();
            this.label_cashBox_0 = new System.Windows.Forms.Label();
            this.label_cashBox_1 = new System.Windows.Forms.Label();
            this.label_cash_3_queue = new System.Windows.Forms.Label();
            this.label_cashBox_2 = new System.Windows.Forms.Label();
            this.label_cash_2_queue = new System.Windows.Forms.Label();
            this.label_cashBox_3 = new System.Windows.Forms.Label();
            this.label_cash_1_queue = new System.Windows.Forms.Label();
            this.label_cash_0_queue = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_entrance = new System.Windows.Forms.Label();
            this.picture_gas_7 = new System.Windows.Forms.PictureBox();
            this.picture_gas_5 = new System.Windows.Forms.PictureBox();
            this.picture_gas_6 = new System.Windows.Forms.PictureBox();
            this.picture_gas_4 = new System.Windows.Forms.PictureBox();
            this.picture_gas_3 = new System.Windows.Forms.PictureBox();
            this.picture_gas_1 = new System.Windows.Forms.PictureBox();
            this.picture_gas_2 = new System.Windows.Forms.PictureBox();
            this.picture_gas_0 = new System.Windows.Forms.PictureBox();
            this.label_menuHeader = new System.Windows.Forms.Label();
            this.label_previewHeader = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_orlen_logo)).BeginInit();
            this.panel_preview.SuspendLayout();
            this.panel_cashes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_0)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.Window;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start.Location = new System.Drawing.Point(17, 18);
            this.button_start.Margin = new System.Windows.Forms.Padding(4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(241, 33);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.Window;
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reset.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reset.Location = new System.Drawing.Point(17, 59);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(241, 33);
            this.button_reset.TabIndex = 2;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_menu.Controls.Add(this.label_progress);
            this.panel_menu.Controls.Add(this.progressBar);
            this.panel_menu.Controls.Add(this.label_activeThreads);
            this.panel_menu.Controls.Add(this.label_activeThreadsHeader);
            this.panel_menu.Controls.Add(this.label_scrollBarHeader);
            this.panel_menu.Controls.Add(this.label_scrollVal);
            this.panel_menu.Controls.Add(this.scrollBar_threads);
            this.panel_menu.Controls.Add(this.label_timeHeader);
            this.panel_menu.Controls.Add(this.label_time);
            this.panel_menu.Controls.Add(this.button_start);
            this.panel_menu.Controls.Add(this.button_reset);
            this.panel_menu.Location = new System.Drawing.Point(960, 52);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(281, 384);
            this.panel_menu.TabIndex = 3;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_progress.Location = new System.Drawing.Point(100, 331);
            this.label_progress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(55, 18);
            this.label_progress.TabIndex = 11;
            this.label_progress.Text = "Postęp";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 358);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(241, 16);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // label_activeThreads
            // 
            this.label_activeThreads.AutoSize = true;
            this.label_activeThreads.BackColor = System.Drawing.SystemColors.Window;
            this.label_activeThreads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_activeThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_activeThreads.Location = new System.Drawing.Point(224, 220);
            this.label_activeThreads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_activeThreads.Name = "label_activeThreads";
            this.label_activeThreads.Size = new System.Drawing.Size(26, 20);
            this.label_activeThreads.TabIndex = 9;
            this.label_activeThreads.Text = "00";
            // 
            // label_activeThreadsHeader
            // 
            this.label_activeThreadsHeader.AutoSize = true;
            this.label_activeThreadsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_activeThreadsHeader.Location = new System.Drawing.Point(13, 220);
            this.label_activeThreadsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_activeThreadsHeader.Name = "label_activeThreadsHeader";
            this.label_activeThreadsHeader.Size = new System.Drawing.Size(152, 18);
            this.label_activeThreadsHeader.TabIndex = 8;
            this.label_activeThreadsHeader.Text = "Aktywnych procesów:";
            // 
            // label_scrollBarHeader
            // 
            this.label_scrollBarHeader.AutoSize = true;
            this.label_scrollBarHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_scrollBarHeader.Location = new System.Drawing.Point(55, 98);
            this.label_scrollBarHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_scrollBarHeader.Name = "label_scrollBarHeader";
            this.label_scrollBarHeader.Size = new System.Drawing.Size(121, 36);
            this.label_scrollBarHeader.TabIndex = 7;
            this.label_scrollBarHeader.Text = "Liczba procesów\r\nsekwencyjnych:";
            this.label_scrollBarHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_scrollVal
            // 
            this.label_scrollVal.AutoSize = true;
            this.label_scrollVal.BackColor = System.Drawing.SystemColors.Window;
            this.label_scrollVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_scrollVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_scrollVal.Location = new System.Drawing.Point(116, 149);
            this.label_scrollVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_scrollVal.Name = "label_scrollVal";
            this.label_scrollVal.Size = new System.Drawing.Size(29, 22);
            this.label_scrollVal.TabIndex = 6;
            this.label_scrollVal.Text = "00";
            // 
            // scrollBar_threads
            // 
            this.scrollBar_threads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollBar_threads.LargeChange = 1;
            this.scrollBar_threads.Location = new System.Drawing.Point(17, 178);
            this.scrollBar_threads.Maximum = 80;
            this.scrollBar_threads.Minimum = 1;
            this.scrollBar_threads.Name = "scrollBar_threads";
            this.scrollBar_threads.Size = new System.Drawing.Size(241, 20);
            this.scrollBar_threads.TabIndex = 5;
            this.scrollBar_threads.Value = 20;
            this.scrollBar_threads.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarThreads_Scroll);
            // 
            // label_timeHeader
            // 
            this.label_timeHeader.AutoSize = true;
            this.label_timeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_timeHeader.Location = new System.Drawing.Point(61, 266);
            this.label_timeHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeHeader.Name = "label_timeHeader";
            this.label_timeHeader.Size = new System.Drawing.Size(112, 18);
            this.label_timeHeader.TabIndex = 4;
            this.label_timeHeader.Text = "Czas symulacji:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.SystemColors.Window;
            this.label_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_time.Location = new System.Drawing.Point(87, 290);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(73, 22);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "00:00:00";
            // 
            // picture_orlen_logo
            // 
            this.picture_orlen_logo.Image = global::PW_Project.Properties.Resources.orlen_logo;
            this.picture_orlen_logo.Location = new System.Drawing.Point(1001, 444);
            this.picture_orlen_logo.Margin = new System.Windows.Forms.Padding(4);
            this.picture_orlen_logo.Name = "picture_orlen_logo";
            this.picture_orlen_logo.Size = new System.Drawing.Size(241, 96);
            this.picture_orlen_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_orlen_logo.TabIndex = 11;
            this.picture_orlen_logo.TabStop = false;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_author.Location = new System.Drawing.Point(1012, 556);
            this.label_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(173, 51);
            this.label_author.TabIndex = 10;
            this.label_author.Text = "Autor:   Bartłomiej Szykuła\r\nWCY19IX3S0\r\n31.01.2022r.";
            this.label_author.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_preview
            // 
            this.panel_preview.BackColor = System.Drawing.Color.Transparent;
            this.panel_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_preview.Controls.Add(this.panel_cashes);
            this.panel_preview.Controls.Add(this.label_exit);
            this.panel_preview.Controls.Add(this.label_entrance);
            this.panel_preview.Controls.Add(this.picture_gas_7);
            this.panel_preview.Controls.Add(this.picture_gas_5);
            this.panel_preview.Controls.Add(this.picture_gas_6);
            this.panel_preview.Controls.Add(this.picture_gas_4);
            this.panel_preview.Controls.Add(this.picture_gas_3);
            this.panel_preview.Controls.Add(this.picture_gas_1);
            this.panel_preview.Controls.Add(this.picture_gas_2);
            this.panel_preview.Controls.Add(this.picture_gas_0);
            this.panel_preview.Location = new System.Drawing.Point(16, 52);
            this.panel_preview.Margin = new System.Windows.Forms.Padding(4);
            this.panel_preview.Name = "panel_preview";
            this.panel_preview.Size = new System.Drawing.Size(935, 552);
            this.panel_preview.TabIndex = 4;
            // 
            // panel_cashes
            // 
            this.panel_cashes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_cashes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_cashes.Controls.Add(this.labelbox_queues_header);
            this.panel_cashes.Controls.Add(this.label_cash_header);
            this.panel_cashes.Controls.Add(this.label_cashBox_0);
            this.panel_cashes.Controls.Add(this.label_cashBox_1);
            this.panel_cashes.Controls.Add(this.label_cash_3_queue);
            this.panel_cashes.Controls.Add(this.label_cashBox_2);
            this.panel_cashes.Controls.Add(this.label_cash_2_queue);
            this.panel_cashes.Controls.Add(this.label_cashBox_3);
            this.panel_cashes.Controls.Add(this.label_cash_1_queue);
            this.panel_cashes.Controls.Add(this.label_cash_0_queue);
            this.panel_cashes.Location = new System.Drawing.Point(363, 18);
            this.panel_cashes.Name = "panel_cashes";
            this.panel_cashes.Size = new System.Drawing.Size(499, 100);
            this.panel_cashes.TabIndex = 38;
            // 
            // labelbox_queues_header
            // 
            this.labelbox_queues_header.AutoSize = true;
            this.labelbox_queues_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelbox_queues_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbox_queues_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelbox_queues_header.Location = new System.Drawing.Point(268, 62);
            this.labelbox_queues_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbox_queues_header.Name = "labelbox_queues_header";
            this.labelbox_queues_header.Size = new System.Drawing.Size(134, 19);
            this.labelbox_queues_header.TabIndex = 36;
            this.labelbox_queues_header.Text = "Ilość osób w kolejce";
            // 
            // label_cash_header
            // 
            this.label_cash_header.AutoSize = true;
            this.label_cash_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cash_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_cash_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cash_header.Location = new System.Drawing.Point(268, 26);
            this.label_cash_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cash_header.Name = "label_cash_header";
            this.label_cash_header.Size = new System.Drawing.Size(41, 19);
            this.label_cash_header.TabIndex = 37;
            this.label_cash_header.Text = "Kasy";
            // 
            // label_cashBox_0
            // 
            this.label_cashBox_0.AutoSize = true;
            this.label_cashBox_0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cashBox_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cashBox_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cashBox_0.Location = new System.Drawing.Point(25, 26);
            this.label_cashBox_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cashBox_0.Name = "label_cashBox_0";
            this.label_cashBox_0.Size = new System.Drawing.Size(19, 20);
            this.label_cashBox_0.TabIndex = 12;
            this.label_cashBox_0.Text = "1";
            // 
            // label_cashBox_1
            // 
            this.label_cashBox_1.AutoSize = true;
            this.label_cashBox_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cashBox_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cashBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cashBox_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_cashBox_1.Location = new System.Drawing.Point(92, 26);
            this.label_cashBox_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cashBox_1.Name = "label_cashBox_1";
            this.label_cashBox_1.Size = new System.Drawing.Size(19, 20);
            this.label_cashBox_1.TabIndex = 29;
            this.label_cashBox_1.Text = "2";
            // 
            // label_cash_3_queue
            // 
            this.label_cash_3_queue.AutoSize = true;
            this.label_cash_3_queue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cash_3_queue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cash_3_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cash_3_queue.Location = new System.Drawing.Point(221, 63);
            this.label_cash_3_queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cash_3_queue.Name = "label_cash_3_queue";
            this.label_cash_3_queue.Size = new System.Drawing.Size(26, 19);
            this.label_cash_3_queue.TabIndex = 35;
            this.label_cash_3_queue.Text = "00";
            // 
            // label_cashBox_2
            // 
            this.label_cashBox_2.AutoSize = true;
            this.label_cashBox_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cashBox_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cashBox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cashBox_2.Location = new System.Drawing.Point(158, 26);
            this.label_cashBox_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cashBox_2.Name = "label_cashBox_2";
            this.label_cashBox_2.Size = new System.Drawing.Size(19, 20);
            this.label_cashBox_2.TabIndex = 30;
            this.label_cashBox_2.Text = "3";
            // 
            // label_cash_2_queue
            // 
            this.label_cash_2_queue.AutoSize = true;
            this.label_cash_2_queue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cash_2_queue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cash_2_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cash_2_queue.Location = new System.Drawing.Point(154, 63);
            this.label_cash_2_queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cash_2_queue.Name = "label_cash_2_queue";
            this.label_cash_2_queue.Size = new System.Drawing.Size(26, 19);
            this.label_cash_2_queue.TabIndex = 34;
            this.label_cash_2_queue.Text = "00";
            // 
            // label_cashBox_3
            // 
            this.label_cashBox_3.AutoSize = true;
            this.label_cashBox_3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cashBox_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cashBox_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cashBox_3.Location = new System.Drawing.Point(225, 26);
            this.label_cashBox_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cashBox_3.Name = "label_cashBox_3";
            this.label_cashBox_3.Size = new System.Drawing.Size(19, 20);
            this.label_cashBox_3.TabIndex = 31;
            this.label_cashBox_3.Text = "4";
            // 
            // label_cash_1_queue
            // 
            this.label_cash_1_queue.AutoSize = true;
            this.label_cash_1_queue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cash_1_queue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cash_1_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cash_1_queue.Location = new System.Drawing.Point(88, 63);
            this.label_cash_1_queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cash_1_queue.Name = "label_cash_1_queue";
            this.label_cash_1_queue.Size = new System.Drawing.Size(26, 19);
            this.label_cash_1_queue.TabIndex = 33;
            this.label_cash_1_queue.Text = "00";
            // 
            // label_cash_0_queue
            // 
            this.label_cash_0_queue.AutoSize = true;
            this.label_cash_0_queue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_cash_0_queue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cash_0_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cash_0_queue.Location = new System.Drawing.Point(21, 63);
            this.label_cash_0_queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cash_0_queue.Name = "label_cash_0_queue";
            this.label_cash_0_queue.Size = new System.Drawing.Size(26, 19);
            this.label_cash_0_queue.TabIndex = 32;
            this.label_cash_0_queue.Text = "00";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_exit.Location = new System.Drawing.Point(848, 521);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(59, 20);
            this.label_exit.TabIndex = 28;
            this.label_exit.Text = "Wyjazd";
            // 
            // label_entrance
            // 
            this.label_entrance.AutoSize = true;
            this.label_entrance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_entrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_entrance.Location = new System.Drawing.Point(4, 6);
            this.label_entrance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_entrance.Name = "label_entrance";
            this.label_entrance.Size = new System.Drawing.Size(52, 20);
            this.label_entrance.TabIndex = 12;
            this.label_entrance.Text = "Wjazd";
            // 
            // picture_gas_7
            // 
            this.picture_gas_7.BackColor = System.Drawing.Color.White;
            this.picture_gas_7.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_7.Image")));
            this.picture_gas_7.Location = new System.Drawing.Point(565, 265);
            this.picture_gas_7.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_7.Name = "picture_gas_7";
            this.picture_gas_7.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_7.TabIndex = 27;
            this.picture_gas_7.TabStop = false;
            // 
            // picture_gas_5
            // 
            this.picture_gas_5.BackColor = System.Drawing.Color.White;
            this.picture_gas_5.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_5.Image")));
            this.picture_gas_5.Location = new System.Drawing.Point(435, 265);
            this.picture_gas_5.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_5.Name = "picture_gas_5";
            this.picture_gas_5.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_5.TabIndex = 26;
            this.picture_gas_5.TabStop = false;
            // 
            // picture_gas_6
            // 
            this.picture_gas_6.BackColor = System.Drawing.Color.White;
            this.picture_gas_6.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_6.Image")));
            this.picture_gas_6.Location = new System.Drawing.Point(565, 222);
            this.picture_gas_6.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_6.Name = "picture_gas_6";
            this.picture_gas_6.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_6.TabIndex = 23;
            this.picture_gas_6.TabStop = false;
            // 
            // picture_gas_4
            // 
            this.picture_gas_4.BackColor = System.Drawing.Color.White;
            this.picture_gas_4.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_4.Image")));
            this.picture_gas_4.Location = new System.Drawing.Point(435, 222);
            this.picture_gas_4.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_4.Name = "picture_gas_4";
            this.picture_gas_4.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_4.TabIndex = 22;
            this.picture_gas_4.TabStop = false;
            // 
            // picture_gas_3
            // 
            this.picture_gas_3.BackColor = System.Drawing.Color.White;
            this.picture_gas_3.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_3.Image")));
            this.picture_gas_3.Location = new System.Drawing.Point(304, 265);
            this.picture_gas_3.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_3.Name = "picture_gas_3";
            this.picture_gas_3.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_3.TabIndex = 17;
            this.picture_gas_3.TabStop = false;
            // 
            // picture_gas_1
            // 
            this.picture_gas_1.BackColor = System.Drawing.Color.White;
            this.picture_gas_1.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_1.Image")));
            this.picture_gas_1.Location = new System.Drawing.Point(173, 265);
            this.picture_gas_1.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_1.Name = "picture_gas_1";
            this.picture_gas_1.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_1.TabIndex = 16;
            this.picture_gas_1.TabStop = false;
            // 
            // picture_gas_2
            // 
            this.picture_gas_2.BackColor = System.Drawing.Color.White;
            this.picture_gas_2.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_2.Image")));
            this.picture_gas_2.Location = new System.Drawing.Point(304, 222);
            this.picture_gas_2.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_2.Name = "picture_gas_2";
            this.picture_gas_2.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_2.TabIndex = 13;
            this.picture_gas_2.TabStop = false;
            // 
            // picture_gas_0
            // 
            this.picture_gas_0.BackColor = System.Drawing.Color.White;
            this.picture_gas_0.Image = ((System.Drawing.Image)(resources.GetObject("picture_gas_0.Image")));
            this.picture_gas_0.Location = new System.Drawing.Point(173, 222);
            this.picture_gas_0.Margin = new System.Windows.Forms.Padding(4);
            this.picture_gas_0.Name = "picture_gas_0";
            this.picture_gas_0.Size = new System.Drawing.Size(27, 32);
            this.picture_gas_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_gas_0.TabIndex = 12;
            this.picture_gas_0.TabStop = false;
            // 
            // label_menuHeader
            // 
            this.label_menuHeader.AutoSize = true;
            this.label_menuHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_menuHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_menuHeader.Location = new System.Drawing.Point(960, 16);
            this.label_menuHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_menuHeader.Name = "label_menuHeader";
            this.label_menuHeader.Size = new System.Drawing.Size(171, 26);
            this.label_menuHeader.TabIndex = 6;
            this.label_menuHeader.Text = "Panel sterowania";
            // 
            // label_previewHeader
            // 
            this.label_previewHeader.AutoSize = true;
            this.label_previewHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_previewHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_previewHeader.Location = new System.Drawing.Point(16, 16);
            this.label_previewHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_previewHeader.Name = "label_previewHeader";
            this.label_previewHeader.Size = new System.Drawing.Size(89, 26);
            this.label_previewHeader.TabIndex = 5;
            this.label_previewHeader.Text = "Podgląd";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.button_start;
            this.ClientSize = new System.Drawing.Size(1284, 641);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_menuHeader);
            this.Controls.Add(this.picture_orlen_logo);
            this.Controls.Add(this.panel_preview);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.label_previewHeader);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orlen Simulator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_orlen_logo)).EndInit();
            this.panel_preview.ResumeLayout(false);
            this.panel_preview.PerformLayout();
            this.panel_cashes.ResumeLayout(false);
            this.panel_cashes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_gas_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label_timeHeader;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Panel panel_preview;
        private System.Windows.Forms.Label label_scrollVal;
        private System.Windows.Forms.Label label_activeThreads;
        private System.Windows.Forms.Label label_activeThreadsHeader;
        private System.Windows.Forms.Label label_scrollBarHeader;
        private System.Windows.Forms.Label label_previewHeader;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_menuHeader;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.HScrollBar scrollBar_threads;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox picture_orlen_logo;
        private System.Windows.Forms.PictureBox picture_gas_0;
        private System.Windows.Forms.PictureBox picture_gas_1;
        private System.Windows.Forms.PictureBox picture_gas_2;
        private System.Windows.Forms.PictureBox picture_gas_3;
        private System.Windows.Forms.PictureBox picture_gas_4;
        private System.Windows.Forms.PictureBox picture_gas_5;
        private System.Windows.Forms.PictureBox picture_gas_6;
        private System.Windows.Forms.PictureBox picture_gas_7;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_entrance;
        private System.Windows.Forms.Label label_cashBox_0;
        private System.Windows.Forms.Label label_cashBox_3;
        private System.Windows.Forms.Label label_cashBox_2;
        private System.Windows.Forms.Label label_cashBox_1;
        private System.Windows.Forms.Label label_cash_header;
        private System.Windows.Forms.Label labelbox_queues_header;
        private System.Windows.Forms.Label label_cash_3_queue;
        private System.Windows.Forms.Label label_cash_2_queue;
        private System.Windows.Forms.Label label_cash_1_queue;
        private System.Windows.Forms.Label label_cash_0_queue;
        private System.Windows.Forms.Panel panel_cashes;
    }
}

