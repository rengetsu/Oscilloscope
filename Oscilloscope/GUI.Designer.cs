
namespace Oscilloscope
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.leftMainTab = new System.Windows.Forms.Panel();
            this.leftTopTab = new System.Windows.Forms.Panel();
            this.leftTopTab_CancelButton = new System.Windows.Forms.PictureBox();
            this.mainTab = new System.Windows.Forms.Panel();
            this.screenPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.glControl1 = new OpenTK.GLControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topControlsPanel = new System.Windows.Forms.Panel();
            this.statusArea_DisplayPanel = new System.Windows.Forms.Panel();
            this.statusArea_Display_PersistenceTime = new System.Windows.Forms.Label();
            this.statusArea_Display_Style = new System.Windows.Forms.Label();
            this.statusArea_DisplayFrame = new System.Windows.Forms.PictureBox();
            this.statusArea_TriggerPanel = new System.Windows.Forms.Panel();
            this.statusArea_Trigger_Style = new System.Windows.Forms.Label();
            this.statusArea_Trigger_Sensitivity = new System.Windows.Forms.Label();
            this.statusArea_Trigger_Frequency = new System.Windows.Forms.Label();
            this.statusArea_Trigger_Mode = new System.Windows.Forms.Label();
            this.statusArea_Trigger_Source = new System.Windows.Forms.Label();
            this.statusArea_TriggerFrame = new System.Windows.Forms.PictureBox();
            this.statusArea_AcquirePanel = new System.Windows.Forms.Panel();
            this.statusArea_Acquire_Waveforms = new System.Windows.Forms.Label();
            this.statusArea_Acquire_Mode = new System.Windows.Forms.Label();
            this.statusArea_Acquire_KS = new System.Windows.Forms.Label();
            this.statusArea_Acquire_SamplingMode = new System.Windows.Forms.Label();
            this.statusArea_Acquire_SampleRate = new System.Windows.Forms.Label();
            this.statusArea_Acquire_Scale = new System.Windows.Forms.Label();
            this.statusArea_AcquireFrame = new System.Windows.Forms.PictureBox();
            this.statusArea_ChannelFourPanel = new System.Windows.Forms.Panel();
            this.statusArea_ChannelFour_Offset = new System.Windows.Forms.Label();
            this.statusArea_ChannelFour_Scale = new System.Windows.Forms.Label();
            this.statusArea_ChannelFourFrame = new System.Windows.Forms.PictureBox();
            this.statusArea_ChannelThreePanel = new System.Windows.Forms.Panel();
            this.statusArea_ChannelThree_Offset = new System.Windows.Forms.Label();
            this.statusArea_ChannelThree_Scale = new System.Windows.Forms.Label();
            this.statusArea_ChannelThreeFrame = new System.Windows.Forms.PictureBox();
            this.statusArea_ChannelTwoPanel = new System.Windows.Forms.Panel();
            this.statusArea_ChannelTwo_Offset = new System.Windows.Forms.Label();
            this.statusArea_ChannelTwo_Scale = new System.Windows.Forms.Label();
            this.statusArea_ChannelTwoFrame = new System.Windows.Forms.PictureBox();
            this.statusArea_ChannelOnePanel = new System.Windows.Forms.Panel();
            this.statusArea_ChannelOne_Offset = new System.Windows.Forms.Label();
            this.statusArea_ChannelOne_Scale = new System.Windows.Forms.Label();
            this.statusArea_ChannelOneFrame = new System.Windows.Forms.PictureBox();
            this.topMenuPanel = new System.Windows.Forms.Panel();
            this.topMenu_ClearButton = new System.Windows.Forms.PictureBox();
            this.topMenu_RunButton = new System.Windows.Forms.PictureBox();
            this.topMenu_StopButton = new System.Windows.Forms.PictureBox();
            this.topMenu_SingleButton = new System.Windows.Forms.PictureBox();
            this.topMenu_AutoscaleButton = new System.Windows.Forms.PictureBox();
            this.topMenu_DefaultButton = new System.Windows.Forms.PictureBox();
            this.topMenu_BackButton = new System.Windows.Forms.PictureBox();
            this.topMenu_ForwardButton = new System.Windows.Forms.PictureBox();
            this.topMenu_CopyButton = new System.Windows.Forms.PictureBox();
            this.topMenu_HelpButton = new System.Windows.Forms.PictureBox();
            this.measurementsPanel = new System.Windows.Forms.Panel();
            this.measurementArea_MinButton = new System.Windows.Forms.PictureBox();
            this.measurementArea_MidButton = new System.Windows.Forms.PictureBox();
            this.measurementArea_MaxButton = new System.Windows.Forms.PictureBox();
            this.measurementArea_AutoButton = new System.Windows.Forms.PictureBox();
            this.measurementArea_ScalesButton = new System.Windows.Forms.PictureBox();
            this.measurementArea_VerticalScale = new System.Windows.Forms.Label();
            this.measurementArea_OffsetPosition = new System.Windows.Forms.Label();
            this.measurementArea_DelayPosition = new System.Windows.Forms.Label();
            this.measurementArea_HorizontalScale = new System.Windows.Forms.Label();
            this.measurementArea_DelayPosition_4ch = new System.Windows.Forms.Label();
            this.measurementArea_DelayPosition_3ch = new System.Windows.Forms.Label();
            this.measurementArea_HorizontalScale_4ch = new System.Windows.Forms.Label();
            this.measurementArea_HorizontalScale_3ch = new System.Windows.Forms.Label();
            this.measurementArea_OffsetPosition_4ch = new System.Windows.Forms.Label();
            this.measurementArea_OffsetPosition_3ch = new System.Windows.Forms.Label();
            this.measurementArea_VerticalScale_4ch = new System.Windows.Forms.Label();
            this.measurementArea_VerticalScale_3ch = new System.Windows.Forms.Label();
            this.measurementArea_ChannelFour = new System.Windows.Forms.Label();
            this.measurementArea_ChannelThree = new System.Windows.Forms.Label();
            this.measurementArea_DelayPosition_2ch = new System.Windows.Forms.Label();
            this.measurementArea_HorizontalScale_2ch = new System.Windows.Forms.Label();
            this.measurementArea_OffsetPosition_2ch = new System.Windows.Forms.Label();
            this.measurementArea_VerticalScale_2ch = new System.Windows.Forms.Label();
            this.measurementArea_ChannelTwo = new System.Windows.Forms.Label();
            this.measurementArea_DelayPosition_1ch = new System.Windows.Forms.Label();
            this.measurementArea_HorizontalScale_1ch = new System.Windows.Forms.Label();
            this.measurementArea_OffsetPosition_1ch = new System.Windows.Forms.Label();
            this.measurementArea_VerticalScale_1ch = new System.Windows.Forms.Label();
            this.measurementArea_ChannelOne = new System.Windows.Forms.Label();
            this.measurementAreaScale = new System.Windows.Forms.PictureBox();
            this.iconPanel = new System.Windows.Forms.PictureBox();
            this.permanentControlsPanel = new System.Windows.Forms.Panel();
            this.triggerLevel_StatusBar = new System.Windows.Forms.PictureBox();
            this.triggerLevel_TextBox = new System.Windows.Forms.TextBox();
            this.triggerLevel_BigUpButton = new System.Windows.Forms.PictureBox();
            this.triggerLevel_BigDownButton = new System.Windows.Forms.PictureBox();
            this.triggerLevel_ZeroButton = new System.Windows.Forms.PictureBox();
            this.triggerLevel_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.triggerLevel_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.triggerMode_TriggeredButton = new System.Windows.Forms.PictureBox();
            this.triggerMode_FreerunButton = new System.Windows.Forms.PictureBox();
            this.triggerSlope_Bislope = new System.Windows.Forms.PictureBox();
            this.triggerSlope_Negative = new System.Windows.Forms.PictureBox();
            this.triggerSlope_Positive = new System.Windows.Forms.PictureBox();
            this.triggerSource_ChannelFour = new System.Windows.Forms.PictureBox();
            this.triggerSource_ChannelThree = new System.Windows.Forms.PictureBox();
            this.triggerSource_ChannelTwo = new System.Windows.Forms.PictureBox();
            this.triggerSource_ChannelOne = new System.Windows.Forms.PictureBox();
            this.timebase_StatusBar = new System.Windows.Forms.PictureBox();
            this.timebase_BigRightButton = new System.Windows.Forms.PictureBox();
            this.timebase_BigLeftButton = new System.Windows.Forms.PictureBox();
            this.timebase_DefaultButton = new System.Windows.Forms.PictureBox();
            this.timebase_SmallRightButton = new System.Windows.Forms.PictureBox();
            this.timebase_SmallLeftButton = new System.Windows.Forms.PictureBox();
            this.timebase_TextBox = new System.Windows.Forms.TextBox();
            this.timebase_PosDelay_StatusBar = new System.Windows.Forms.PictureBox();
            this.timebase_PosDelay_BigRightButton = new System.Windows.Forms.PictureBox();
            this.timebase_PosDelay_BigLeftButton = new System.Windows.Forms.PictureBox();
            this.timebase_PosDelay_DefaultButton = new System.Windows.Forms.PictureBox();
            this.timebase_PosDelay_SmallRightButton = new System.Windows.Forms.PictureBox();
            this.timebase_PosDelay_SmallLeftButton = new System.Windows.Forms.PictureBox();
            this.timebase_PosDelay_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelFour_OffsetButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PositionButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_OffsetButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_PositionButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_OffsetButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_PositionButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_OffsetButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_PositionButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PosOfs_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PosOfs_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PosOfs_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PosOfs_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PosOfs_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PosOfs_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_PosOfs_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelThree_PosOfs_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelThree_PosOfs_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_PosOfs_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_PosOfs_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_PosOfs_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_PosOfs_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_PosOfs_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelTwo_PosOfs_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_PosOfs_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_PosOfs_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_PosOfs_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_PosOfs_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_PosOfs_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_PosOfs_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelOne_PosOfs_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelOne_PosOfs_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelOne_PosOfs_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_PosOfs_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_PosOfs_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_PosOfs_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_PosOfs_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelFour_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelFour_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelThree_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelThree_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelThree_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelFour_Button = new System.Windows.Forms.PictureBox();
            this.ChannelThree_Button = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelOne_StatusBar = new System.Windows.Forms.PictureBox();
            this.ChannelOne_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelOne_BigUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_BigDownButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_DefaultButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_SmallUpButton = new System.Windows.Forms.PictureBox();
            this.ChannelOne_SmallDownButton = new System.Windows.Forms.PictureBox();
            this.timebase_DelayButton = new System.Windows.Forms.PictureBox();
            this.timebase_PositionButton = new System.Windows.Forms.PictureBox();
            this.ChannelTwo_Button = new System.Windows.Forms.PictureBox();
            this.ChannelOne_Button = new System.Windows.Forms.PictureBox();
            this.downMenuPanel = new System.Windows.Forms.Panel();
            this.downMenu_EmptyButtons = new System.Windows.Forms.PictureBox();
            this.downMenu_UtilityButton = new System.Windows.Forms.PictureBox();
            this.downMenu_MaskButton = new System.Windows.Forms.PictureBox();
            this.downMenu_DiagramButton = new System.Windows.Forms.PictureBox();
            this.downMenu_HistogramButton = new System.Windows.Forms.PictureBox();
            this.downMenu_RightMouseIcon = new System.Windows.Forms.PictureBox();
            this.downMenu_LeftMouseIcon = new System.Windows.Forms.PictureBox();
            this.downMenu_MathButton = new System.Windows.Forms.PictureBox();
            this.downMenu_DisplayButton = new System.Windows.Forms.PictureBox();
            this.downMenu_MeasureButton = new System.Windows.Forms.PictureBox();
            this.downMenu_ChannelsButton = new System.Windows.Forms.PictureBox();
            this.downMenu_MarkerButton = new System.Windows.Forms.PictureBox();
            this.downMenu_AcquireButton = new System.Windows.Forms.PictureBox();
            this.downMenu_SaveButton = new System.Windows.Forms.PictureBox();
            this.downMenu_TriggerButton = new System.Windows.Forms.PictureBox();
            this.rightMainTab = new System.Windows.Forms.Panel();
            this.rightTopTab = new System.Windows.Forms.Panel();
            this.rightTopTab_CancelButton = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wfmMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invisibleAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadWfmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMemoryM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMemoryM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMemoryM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMemoryM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWaveformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFactorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPowerOffSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsDefaultSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDfltSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFullWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyClientAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyInvClientAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyScopeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyInvScopeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permanentControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftSideMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSideMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothSideMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSideMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStyleScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayViewColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touchscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixedPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatingPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeDotsEnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timebaseAcquisitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limitTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eyeDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterEyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definitionEyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathematicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonLANSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanningLANSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picoSample4HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftMainTab.SuspendLayout();
            this.leftTopTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopTab_CancelButton)).BeginInit();
            this.mainTab.SuspendLayout();
            this.screenPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topControlsPanel.SuspendLayout();
            this.statusArea_DisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_DisplayFrame)).BeginInit();
            this.statusArea_TriggerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_TriggerFrame)).BeginInit();
            this.statusArea_AcquirePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_AcquireFrame)).BeginInit();
            this.statusArea_ChannelFourPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelFourFrame)).BeginInit();
            this.statusArea_ChannelThreePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelThreeFrame)).BeginInit();
            this.statusArea_ChannelTwoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelTwoFrame)).BeginInit();
            this.statusArea_ChannelOnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelOneFrame)).BeginInit();
            this.topMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_ClearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_RunButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_SingleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_AutoscaleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_ForwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_CopyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_HelpButton)).BeginInit();
            this.measurementsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_MidButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_MaxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_AutoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_ScalesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementAreaScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPanel)).BeginInit();
            this.permanentControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_ZeroButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerMode_TriggeredButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerMode_FreerunButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSlope_Bislope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSlope_Negative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSlope_Positive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_BigRightButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_BigLeftButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_SmallRightButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_SmallLeftButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_BigRightButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_BigLeftButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_SmallRightButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_SmallLeftButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_OffsetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PositionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_OffsetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PositionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_OffsetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PositionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_OffsetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PositionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_BigUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_BigDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_DefaultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_SmallUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_SmallDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_DelayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PositionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_Button)).BeginInit();
            this.downMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_EmptyButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_UtilityButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MaskButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_DiagramButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_HistogramButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_RightMouseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_LeftMouseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MathButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_DisplayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MeasureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_ChannelsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MarkerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_AcquireButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_SaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_TriggerButton)).BeginInit();
            this.rightMainTab.SuspendLayout();
            this.rightTopTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightTopTab_CancelButton)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMainTab
            // 
            this.leftMainTab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.leftMainTab.Controls.Add(this.leftTopTab);
            this.leftMainTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMainTab.Location = new System.Drawing.Point(0, 24);
            this.leftMainTab.Margin = new System.Windows.Forms.Padding(0);
            this.leftMainTab.Name = "leftMainTab";
            this.leftMainTab.Size = new System.Drawing.Size(230, 680);
            this.leftMainTab.TabIndex = 1;
            this.leftMainTab.Visible = false;
            // 
            // leftTopTab
            // 
            this.leftTopTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.leftTopTab.Controls.Add(this.leftTopTab_CancelButton);
            this.leftTopTab.Location = new System.Drawing.Point(0, 0);
            this.leftTopTab.Margin = new System.Windows.Forms.Padding(0);
            this.leftTopTab.Name = "leftTopTab";
            this.leftTopTab.Size = new System.Drawing.Size(230, 56);
            this.leftTopTab.TabIndex = 0;
            // 
            // leftTopTab_CancelButton
            // 
            this.leftTopTab_CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("leftTopTab_CancelButton.Image")));
            this.leftTopTab_CancelButton.Location = new System.Drawing.Point(189, 6);
            this.leftTopTab_CancelButton.Name = "leftTopTab_CancelButton";
            this.leftTopTab_CancelButton.Size = new System.Drawing.Size(23, 21);
            this.leftTopTab_CancelButton.TabIndex = 0;
            this.leftTopTab_CancelButton.TabStop = false;
            this.leftTopTab_CancelButton.Click += new System.EventHandler(this.leftTopTab_CancelButton_Click);
            // 
            // mainTab
            // 
            this.mainTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTab.BackColor = System.Drawing.Color.Silver;
            this.mainTab.Controls.Add(this.screenPanel);
            this.mainTab.Controls.Add(this.topControlsPanel);
            this.mainTab.Controls.Add(this.topMenuPanel);
            this.mainTab.Controls.Add(this.measurementsPanel);
            this.mainTab.Controls.Add(this.permanentControlsPanel);
            this.mainTab.Controls.Add(this.downMenuPanel);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Location = new System.Drawing.Point(230, 24);
            this.mainTab.Name = "mainTab";
            this.mainTab.Size = new System.Drawing.Size(1040, 680);
            this.mainTab.TabIndex = 3;
            // 
            // screenPanel
            // 
            this.screenPanel.BackColor = System.Drawing.Color.Black;
            this.screenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenPanel.Controls.Add(this.panel1);
            this.screenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.screenPanel.Location = new System.Drawing.Point(0, 68);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(1040, 347);
            this.screenPanel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.glControl1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(38, 0, 33, 0);
            this.panel1.Size = new System.Drawing.Size(1040, 347);
            this.panel1.TabIndex = 0;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(38, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(969, 347);
            this.glControl1.TabIndex = 1;
            this.glControl1.VSync = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(969, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // topControlsPanel
            // 
            this.topControlsPanel.BackColor = System.Drawing.Color.Black;
            this.topControlsPanel.Controls.Add(this.statusArea_DisplayPanel);
            this.topControlsPanel.Controls.Add(this.statusArea_TriggerPanel);
            this.topControlsPanel.Controls.Add(this.statusArea_AcquirePanel);
            this.topControlsPanel.Controls.Add(this.statusArea_ChannelFourPanel);
            this.topControlsPanel.Controls.Add(this.statusArea_ChannelThreePanel);
            this.topControlsPanel.Controls.Add(this.statusArea_ChannelTwoPanel);
            this.topControlsPanel.Controls.Add(this.statusArea_ChannelOnePanel);
            this.topControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topControlsPanel.Location = new System.Drawing.Point(0, 27);
            this.topControlsPanel.Name = "topControlsPanel";
            this.topControlsPanel.Size = new System.Drawing.Size(1040, 41);
            this.topControlsPanel.TabIndex = 16;
            // 
            // statusArea_DisplayPanel
            // 
            this.statusArea_DisplayPanel.Controls.Add(this.statusArea_Display_PersistenceTime);
            this.statusArea_DisplayPanel.Controls.Add(this.statusArea_Display_Style);
            this.statusArea_DisplayPanel.Controls.Add(this.statusArea_DisplayFrame);
            this.statusArea_DisplayPanel.Location = new System.Drawing.Point(807, 3);
            this.statusArea_DisplayPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_DisplayPanel.Name = "statusArea_DisplayPanel";
            this.statusArea_DisplayPanel.Size = new System.Drawing.Size(150, 38);
            this.statusArea_DisplayPanel.TabIndex = 6;
            // 
            // statusArea_Display_PersistenceTime
            // 
            this.statusArea_Display_PersistenceTime.AutoSize = true;
            this.statusArea_Display_PersistenceTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Display_PersistenceTime.ForeColor = System.Drawing.Color.White;
            this.statusArea_Display_PersistenceTime.Location = new System.Drawing.Point(111, 3);
            this.statusArea_Display_PersistenceTime.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_Display_PersistenceTime.Name = "statusArea_Display_PersistenceTime";
            this.statusArea_Display_PersistenceTime.Size = new System.Drawing.Size(23, 14);
            this.statusArea_Display_PersistenceTime.TabIndex = 8;
            this.statusArea_Display_PersistenceTime.Text = "2 s";
            // 
            // statusArea_Display_Style
            // 
            this.statusArea_Display_Style.AutoSize = true;
            this.statusArea_Display_Style.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Display_Style.ForeColor = System.Drawing.Color.White;
            this.statusArea_Display_Style.Location = new System.Drawing.Point(1, 3);
            this.statusArea_Display_Style.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_Display_Style.Name = "statusArea_Display_Style";
            this.statusArea_Display_Style.Size = new System.Drawing.Size(78, 14);
            this.statusArea_Display_Style.TabIndex = 7;
            this.statusArea_Display_Style.Text = "Dots Persist.";
            // 
            // statusArea_DisplayFrame
            // 
            this.statusArea_DisplayFrame.Image = ((System.Drawing.Image)(resources.GetObject("statusArea_DisplayFrame.Image")));
            this.statusArea_DisplayFrame.Location = new System.Drawing.Point(0, 0);
            this.statusArea_DisplayFrame.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_DisplayFrame.Name = "statusArea_DisplayFrame";
            this.statusArea_DisplayFrame.Size = new System.Drawing.Size(150, 36);
            this.statusArea_DisplayFrame.TabIndex = 0;
            this.statusArea_DisplayFrame.TabStop = false;
            // 
            // statusArea_TriggerPanel
            // 
            this.statusArea_TriggerPanel.Controls.Add(this.statusArea_Trigger_Style);
            this.statusArea_TriggerPanel.Controls.Add(this.statusArea_Trigger_Sensitivity);
            this.statusArea_TriggerPanel.Controls.Add(this.statusArea_Trigger_Frequency);
            this.statusArea_TriggerPanel.Controls.Add(this.statusArea_Trigger_Mode);
            this.statusArea_TriggerPanel.Controls.Add(this.statusArea_Trigger_Source);
            this.statusArea_TriggerPanel.Controls.Add(this.statusArea_TriggerFrame);
            this.statusArea_TriggerPanel.Location = new System.Drawing.Point(652, 3);
            this.statusArea_TriggerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_TriggerPanel.Name = "statusArea_TriggerPanel";
            this.statusArea_TriggerPanel.Size = new System.Drawing.Size(146, 38);
            this.statusArea_TriggerPanel.TabIndex = 5;
            // 
            // statusArea_Trigger_Style
            // 
            this.statusArea_Trigger_Style.AutoSize = true;
            this.statusArea_Trigger_Style.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Trigger_Style.ForeColor = System.Drawing.Color.White;
            this.statusArea_Trigger_Style.Location = new System.Drawing.Point(41, 3);
            this.statusArea_Trigger_Style.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_Trigger_Style.Name = "statusArea_Trigger_Style";
            this.statusArea_Trigger_Style.Size = new System.Drawing.Size(34, 14);
            this.statusArea_Trigger_Style.TabIndex = 6;
            this.statusArea_Trigger_Style.Text = "Edge";
            // 
            // statusArea_Trigger_Sensitivity
            // 
            this.statusArea_Trigger_Sensitivity.AutoSize = true;
            this.statusArea_Trigger_Sensitivity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Trigger_Sensitivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.statusArea_Trigger_Sensitivity.Location = new System.Drawing.Point(98, 3);
            this.statusArea_Trigger_Sensitivity.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_Trigger_Sensitivity.Name = "statusArea_Trigger_Sensitivity";
            this.statusArea_Trigger_Sensitivity.Size = new System.Drawing.Size(31, 14);
            this.statusArea_Trigger_Sensitivity.TabIndex = 5;
            this.statusArea_Trigger_Sensitivity.Text = "High";
            // 
            // statusArea_Trigger_Frequency
            // 
            this.statusArea_Trigger_Frequency.AutoSize = true;
            this.statusArea_Trigger_Frequency.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Trigger_Frequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.statusArea_Trigger_Frequency.Location = new System.Drawing.Point(54, 19);
            this.statusArea_Trigger_Frequency.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_Trigger_Frequency.Name = "statusArea_Trigger_Frequency";
            this.statusArea_Trigger_Frequency.Size = new System.Drawing.Size(91, 14);
            this.statusArea_Trigger_Frequency.TabIndex = 4;
            this.statusArea_Trigger_Frequency.Text = "f=33.333 33 MHz";
            // 
            // statusArea_Trigger_Mode
            // 
            this.statusArea_Trigger_Mode.AutoSize = true;
            this.statusArea_Trigger_Mode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Trigger_Mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(92)))), ((int)(((byte)(220)))));
            this.statusArea_Trigger_Mode.Location = new System.Drawing.Point(1, 19);
            this.statusArea_Trigger_Mode.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_Trigger_Mode.Name = "statusArea_Trigger_Mode";
            this.statusArea_Trigger_Mode.Size = new System.Drawing.Size(38, 14);
            this.statusArea_Trigger_Mode.TabIndex = 3;
            this.statusArea_Trigger_Mode.Text = "Trig\'d";
            // 
            // statusArea_Trigger_Source
            // 
            this.statusArea_Trigger_Source.AutoSize = true;
            this.statusArea_Trigger_Source.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Trigger_Source.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.statusArea_Trigger_Source.Location = new System.Drawing.Point(1, 3);
            this.statusArea_Trigger_Source.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_Trigger_Source.Name = "statusArea_Trigger_Source";
            this.statusArea_Trigger_Source.Size = new System.Drawing.Size(37, 14);
            this.statusArea_Trigger_Source.TabIndex = 2;
            this.statusArea_Trigger_Source.Text = "Ch1  /";
            // 
            // statusArea_TriggerFrame
            // 
            this.statusArea_TriggerFrame.Image = ((System.Drawing.Image)(resources.GetObject("statusArea_TriggerFrame.Image")));
            this.statusArea_TriggerFrame.Location = new System.Drawing.Point(0, 0);
            this.statusArea_TriggerFrame.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_TriggerFrame.Name = "statusArea_TriggerFrame";
            this.statusArea_TriggerFrame.Size = new System.Drawing.Size(146, 36);
            this.statusArea_TriggerFrame.TabIndex = 0;
            this.statusArea_TriggerFrame.TabStop = false;
            // 
            // statusArea_AcquirePanel
            // 
            this.statusArea_AcquirePanel.Controls.Add(this.statusArea_Acquire_Waveforms);
            this.statusArea_AcquirePanel.Controls.Add(this.statusArea_Acquire_Mode);
            this.statusArea_AcquirePanel.Controls.Add(this.statusArea_Acquire_KS);
            this.statusArea_AcquirePanel.Controls.Add(this.statusArea_Acquire_SamplingMode);
            this.statusArea_AcquirePanel.Controls.Add(this.statusArea_Acquire_SampleRate);
            this.statusArea_AcquirePanel.Controls.Add(this.statusArea_Acquire_Scale);
            this.statusArea_AcquirePanel.Controls.Add(this.statusArea_AcquireFrame);
            this.statusArea_AcquirePanel.Location = new System.Drawing.Point(473, 3);
            this.statusArea_AcquirePanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_AcquirePanel.Name = "statusArea_AcquirePanel";
            this.statusArea_AcquirePanel.Size = new System.Drawing.Size(170, 38);
            this.statusArea_AcquirePanel.TabIndex = 4;
            // 
            // statusArea_Acquire_Waveforms
            // 
            this.statusArea_Acquire_Waveforms.AutoSize = true;
            this.statusArea_Acquire_Waveforms.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Acquire_Waveforms.ForeColor = System.Drawing.Color.Lime;
            this.statusArea_Acquire_Waveforms.Location = new System.Drawing.Point(110, 19);
            this.statusArea_Acquire_Waveforms.Name = "statusArea_Acquire_Waveforms";
            this.statusArea_Acquire_Waveforms.Size = new System.Drawing.Size(41, 14);
            this.statusArea_Acquire_Waveforms.TabIndex = 6;
            this.statusArea_Acquire_Waveforms.Text = "1 Wfm";
            // 
            // statusArea_Acquire_Mode
            // 
            this.statusArea_Acquire_Mode.AutoSize = true;
            this.statusArea_Acquire_Mode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Acquire_Mode.ForeColor = System.Drawing.Color.White;
            this.statusArea_Acquire_Mode.Location = new System.Drawing.Point(109, 3);
            this.statusArea_Acquire_Mode.Name = "statusArea_Acquire_Mode";
            this.statusArea_Acquire_Mode.Size = new System.Drawing.Size(48, 14);
            this.statusArea_Acquire_Mode.TabIndex = 5;
            this.statusArea_Acquire_Mode.Text = "Sample";
            // 
            // statusArea_Acquire_KS
            // 
            this.statusArea_Acquire_KS.AutoSize = true;
            this.statusArea_Acquire_KS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Acquire_KS.ForeColor = System.Drawing.Color.White;
            this.statusArea_Acquire_KS.Location = new System.Drawing.Point(60, 19);
            this.statusArea_Acquire_KS.Name = "statusArea_Acquire_KS";
            this.statusArea_Acquire_KS.Size = new System.Drawing.Size(30, 14);
            this.statusArea_Acquire_KS.TabIndex = 4;
            this.statusArea_Acquire_KS.Text = "2 KS";
            // 
            // statusArea_Acquire_SamplingMode
            // 
            this.statusArea_Acquire_SamplingMode.AutoSize = true;
            this.statusArea_Acquire_SamplingMode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Acquire_SamplingMode.ForeColor = System.Drawing.Color.White;
            this.statusArea_Acquire_SamplingMode.Location = new System.Drawing.Point(67, 3);
            this.statusArea_Acquire_SamplingMode.Name = "statusArea_Acquire_SamplingMode";
            this.statusArea_Acquire_SamplingMode.Size = new System.Drawing.Size(20, 14);
            this.statusArea_Acquire_SamplingMode.TabIndex = 3;
            this.statusArea_Acquire_SamplingMode.Text = "ET";
            // 
            // statusArea_Acquire_SampleRate
            // 
            this.statusArea_Acquire_SampleRate.AutoSize = true;
            this.statusArea_Acquire_SampleRate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Acquire_SampleRate.ForeColor = System.Drawing.Color.White;
            this.statusArea_Acquire_SampleRate.Location = new System.Drawing.Point(1, 19);
            this.statusArea_Acquire_SampleRate.Name = "statusArea_Acquire_SampleRate";
            this.statusArea_Acquire_SampleRate.Size = new System.Drawing.Size(53, 14);
            this.statusArea_Acquire_SampleRate.TabIndex = 2;
            this.statusArea_Acquire_SampleRate.Text = "20 GSa/s";
            // 
            // statusArea_Acquire_Scale
            // 
            this.statusArea_Acquire_Scale.AutoSize = true;
            this.statusArea_Acquire_Scale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_Acquire_Scale.ForeColor = System.Drawing.Color.White;
            this.statusArea_Acquire_Scale.Location = new System.Drawing.Point(1, 3);
            this.statusArea_Acquire_Scale.Name = "statusArea_Acquire_Scale";
            this.statusArea_Acquire_Scale.Size = new System.Drawing.Size(39, 14);
            this.statusArea_Acquire_Scale.TabIndex = 1;
            this.statusArea_Acquire_Scale.Text = "10 ns/";
            // 
            // statusArea_AcquireFrame
            // 
            this.statusArea_AcquireFrame.Image = ((System.Drawing.Image)(resources.GetObject("statusArea_AcquireFrame.Image")));
            this.statusArea_AcquireFrame.Location = new System.Drawing.Point(0, 0);
            this.statusArea_AcquireFrame.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_AcquireFrame.Name = "statusArea_AcquireFrame";
            this.statusArea_AcquireFrame.Size = new System.Drawing.Size(170, 36);
            this.statusArea_AcquireFrame.TabIndex = 0;
            this.statusArea_AcquireFrame.TabStop = false;
            // 
            // statusArea_ChannelFourPanel
            // 
            this.statusArea_ChannelFourPanel.Controls.Add(this.statusArea_ChannelFour_Offset);
            this.statusArea_ChannelFourPanel.Controls.Add(this.statusArea_ChannelFour_Scale);
            this.statusArea_ChannelFourPanel.Controls.Add(this.statusArea_ChannelFourFrame);
            this.statusArea_ChannelFourPanel.Location = new System.Drawing.Point(354, 3);
            this.statusArea_ChannelFourPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelFourPanel.Name = "statusArea_ChannelFourPanel";
            this.statusArea_ChannelFourPanel.Size = new System.Drawing.Size(110, 38);
            this.statusArea_ChannelFourPanel.TabIndex = 3;
            // 
            // statusArea_ChannelFour_Offset
            // 
            this.statusArea_ChannelFour_Offset.AutoSize = true;
            this.statusArea_ChannelFour_Offset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelFour_Offset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.statusArea_ChannelFour_Offset.Location = new System.Drawing.Point(3, 19);
            this.statusArea_ChannelFour_Offset.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelFour_Offset.Name = "statusArea_ChannelFour_Offset";
            this.statusArea_ChannelFour_Offset.Size = new System.Drawing.Size(24, 14);
            this.statusArea_ChannelFour_Offset.TabIndex = 5;
            this.statusArea_ChannelFour_Offset.Text = "0 V";
            // 
            // statusArea_ChannelFour_Scale
            // 
            this.statusArea_ChannelFour_Scale.AutoSize = true;
            this.statusArea_ChannelFour_Scale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelFour_Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.statusArea_ChannelFour_Scale.Location = new System.Drawing.Point(1, 3);
            this.statusArea_ChannelFour_Scale.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelFour_Scale.Name = "statusArea_ChannelFour_Scale";
            this.statusArea_ChannelFour_Scale.Size = new System.Drawing.Size(50, 14);
            this.statusArea_ChannelFour_Scale.TabIndex = 4;
            this.statusArea_ChannelFour_Scale.Text = "100 mV/";
            // 
            // statusArea_ChannelFourFrame
            // 
            this.statusArea_ChannelFourFrame.Image = ((System.Drawing.Image)(resources.GetObject("statusArea_ChannelFourFrame.Image")));
            this.statusArea_ChannelFourFrame.Location = new System.Drawing.Point(0, 0);
            this.statusArea_ChannelFourFrame.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelFourFrame.Name = "statusArea_ChannelFourFrame";
            this.statusArea_ChannelFourFrame.Size = new System.Drawing.Size(110, 36);
            this.statusArea_ChannelFourFrame.TabIndex = 0;
            this.statusArea_ChannelFourFrame.TabStop = false;
            // 
            // statusArea_ChannelThreePanel
            // 
            this.statusArea_ChannelThreePanel.Controls.Add(this.statusArea_ChannelThree_Offset);
            this.statusArea_ChannelThreePanel.Controls.Add(this.statusArea_ChannelThree_Scale);
            this.statusArea_ChannelThreePanel.Controls.Add(this.statusArea_ChannelThreeFrame);
            this.statusArea_ChannelThreePanel.Location = new System.Drawing.Point(241, 3);
            this.statusArea_ChannelThreePanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelThreePanel.Name = "statusArea_ChannelThreePanel";
            this.statusArea_ChannelThreePanel.Size = new System.Drawing.Size(110, 38);
            this.statusArea_ChannelThreePanel.TabIndex = 2;
            // 
            // statusArea_ChannelThree_Offset
            // 
            this.statusArea_ChannelThree_Offset.AutoSize = true;
            this.statusArea_ChannelThree_Offset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelThree_Offset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.statusArea_ChannelThree_Offset.Location = new System.Drawing.Point(3, 19);
            this.statusArea_ChannelThree_Offset.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelThree_Offset.Name = "statusArea_ChannelThree_Offset";
            this.statusArea_ChannelThree_Offset.Size = new System.Drawing.Size(24, 14);
            this.statusArea_ChannelThree_Offset.TabIndex = 4;
            this.statusArea_ChannelThree_Offset.Text = "0 V";
            // 
            // statusArea_ChannelThree_Scale
            // 
            this.statusArea_ChannelThree_Scale.AutoSize = true;
            this.statusArea_ChannelThree_Scale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelThree_Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.statusArea_ChannelThree_Scale.Location = new System.Drawing.Point(1, 3);
            this.statusArea_ChannelThree_Scale.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelThree_Scale.Name = "statusArea_ChannelThree_Scale";
            this.statusArea_ChannelThree_Scale.Size = new System.Drawing.Size(50, 14);
            this.statusArea_ChannelThree_Scale.TabIndex = 3;
            this.statusArea_ChannelThree_Scale.Text = "100 mV/";
            // 
            // statusArea_ChannelThreeFrame
            // 
            this.statusArea_ChannelThreeFrame.Image = ((System.Drawing.Image)(resources.GetObject("statusArea_ChannelThreeFrame.Image")));
            this.statusArea_ChannelThreeFrame.Location = new System.Drawing.Point(0, 0);
            this.statusArea_ChannelThreeFrame.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelThreeFrame.Name = "statusArea_ChannelThreeFrame";
            this.statusArea_ChannelThreeFrame.Size = new System.Drawing.Size(110, 36);
            this.statusArea_ChannelThreeFrame.TabIndex = 0;
            this.statusArea_ChannelThreeFrame.TabStop = false;
            // 
            // statusArea_ChannelTwoPanel
            // 
            this.statusArea_ChannelTwoPanel.Controls.Add(this.statusArea_ChannelTwo_Offset);
            this.statusArea_ChannelTwoPanel.Controls.Add(this.statusArea_ChannelTwo_Scale);
            this.statusArea_ChannelTwoPanel.Controls.Add(this.statusArea_ChannelTwoFrame);
            this.statusArea_ChannelTwoPanel.Location = new System.Drawing.Point(128, 3);
            this.statusArea_ChannelTwoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelTwoPanel.Name = "statusArea_ChannelTwoPanel";
            this.statusArea_ChannelTwoPanel.Size = new System.Drawing.Size(110, 38);
            this.statusArea_ChannelTwoPanel.TabIndex = 1;
            // 
            // statusArea_ChannelTwo_Offset
            // 
            this.statusArea_ChannelTwo_Offset.AutoSize = true;
            this.statusArea_ChannelTwo_Offset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelTwo_Offset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusArea_ChannelTwo_Offset.Location = new System.Drawing.Point(3, 19);
            this.statusArea_ChannelTwo_Offset.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelTwo_Offset.Name = "statusArea_ChannelTwo_Offset";
            this.statusArea_ChannelTwo_Offset.Size = new System.Drawing.Size(24, 14);
            this.statusArea_ChannelTwo_Offset.TabIndex = 3;
            this.statusArea_ChannelTwo_Offset.Text = "0 V";
            // 
            // statusArea_ChannelTwo_Scale
            // 
            this.statusArea_ChannelTwo_Scale.AutoSize = true;
            this.statusArea_ChannelTwo_Scale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelTwo_Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusArea_ChannelTwo_Scale.Location = new System.Drawing.Point(1, 3);
            this.statusArea_ChannelTwo_Scale.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelTwo_Scale.Name = "statusArea_ChannelTwo_Scale";
            this.statusArea_ChannelTwo_Scale.Size = new System.Drawing.Size(50, 14);
            this.statusArea_ChannelTwo_Scale.TabIndex = 2;
            this.statusArea_ChannelTwo_Scale.Text = "100 mV/";
            // 
            // statusArea_ChannelTwoFrame
            // 
            this.statusArea_ChannelTwoFrame.Image = ((System.Drawing.Image)(resources.GetObject("statusArea_ChannelTwoFrame.Image")));
            this.statusArea_ChannelTwoFrame.Location = new System.Drawing.Point(0, 0);
            this.statusArea_ChannelTwoFrame.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelTwoFrame.Name = "statusArea_ChannelTwoFrame";
            this.statusArea_ChannelTwoFrame.Size = new System.Drawing.Size(110, 36);
            this.statusArea_ChannelTwoFrame.TabIndex = 0;
            this.statusArea_ChannelTwoFrame.TabStop = false;
            // 
            // statusArea_ChannelOnePanel
            // 
            this.statusArea_ChannelOnePanel.Controls.Add(this.statusArea_ChannelOne_Offset);
            this.statusArea_ChannelOnePanel.Controls.Add(this.statusArea_ChannelOne_Scale);
            this.statusArea_ChannelOnePanel.Controls.Add(this.statusArea_ChannelOneFrame);
            this.statusArea_ChannelOnePanel.Location = new System.Drawing.Point(15, 3);
            this.statusArea_ChannelOnePanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelOnePanel.Name = "statusArea_ChannelOnePanel";
            this.statusArea_ChannelOnePanel.Size = new System.Drawing.Size(110, 38);
            this.statusArea_ChannelOnePanel.TabIndex = 0;
            // 
            // statusArea_ChannelOne_Offset
            // 
            this.statusArea_ChannelOne_Offset.AutoSize = true;
            this.statusArea_ChannelOne_Offset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelOne_Offset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.statusArea_ChannelOne_Offset.Location = new System.Drawing.Point(3, 19);
            this.statusArea_ChannelOne_Offset.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelOne_Offset.Name = "statusArea_ChannelOne_Offset";
            this.statusArea_ChannelOne_Offset.Size = new System.Drawing.Size(24, 14);
            this.statusArea_ChannelOne_Offset.TabIndex = 2;
            this.statusArea_ChannelOne_Offset.Text = "0 V";
            // 
            // statusArea_ChannelOne_Scale
            // 
            this.statusArea_ChannelOne_Scale.AutoSize = true;
            this.statusArea_ChannelOne_Scale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusArea_ChannelOne_Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.statusArea_ChannelOne_Scale.Location = new System.Drawing.Point(1, 3);
            this.statusArea_ChannelOne_Scale.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelOne_Scale.Name = "statusArea_ChannelOne_Scale";
            this.statusArea_ChannelOne_Scale.Size = new System.Drawing.Size(50, 14);
            this.statusArea_ChannelOne_Scale.TabIndex = 1;
            this.statusArea_ChannelOne_Scale.Text = "100 mV/";
            // 
            // statusArea_ChannelOneFrame
            // 
            this.statusArea_ChannelOneFrame.Image = ((System.Drawing.Image)(resources.GetObject("statusArea_ChannelOneFrame.Image")));
            this.statusArea_ChannelOneFrame.Location = new System.Drawing.Point(0, 0);
            this.statusArea_ChannelOneFrame.Margin = new System.Windows.Forms.Padding(0);
            this.statusArea_ChannelOneFrame.Name = "statusArea_ChannelOneFrame";
            this.statusArea_ChannelOneFrame.Size = new System.Drawing.Size(110, 36);
            this.statusArea_ChannelOneFrame.TabIndex = 0;
            this.statusArea_ChannelOneFrame.TabStop = false;
            // 
            // topMenuPanel
            // 
            this.topMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.topMenuPanel.Controls.Add(this.topMenu_ClearButton);
            this.topMenuPanel.Controls.Add(this.topMenu_RunButton);
            this.topMenuPanel.Controls.Add(this.topMenu_StopButton);
            this.topMenuPanel.Controls.Add(this.topMenu_SingleButton);
            this.topMenuPanel.Controls.Add(this.topMenu_AutoscaleButton);
            this.topMenuPanel.Controls.Add(this.topMenu_DefaultButton);
            this.topMenuPanel.Controls.Add(this.topMenu_BackButton);
            this.topMenuPanel.Controls.Add(this.topMenu_ForwardButton);
            this.topMenuPanel.Controls.Add(this.topMenu_CopyButton);
            this.topMenuPanel.Controls.Add(this.topMenu_HelpButton);
            this.topMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.topMenuPanel.Name = "topMenuPanel";
            this.topMenuPanel.Size = new System.Drawing.Size(1040, 27);
            this.topMenuPanel.TabIndex = 15;
            // 
            // topMenu_ClearButton
            // 
            this.topMenu_ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_ClearButton.Image")));
            this.topMenu_ClearButton.Location = new System.Drawing.Point(3, 1);
            this.topMenu_ClearButton.Name = "topMenu_ClearButton";
            this.topMenu_ClearButton.Size = new System.Drawing.Size(75, 24);
            this.topMenu_ClearButton.TabIndex = 9;
            this.topMenu_ClearButton.TabStop = false;
            // 
            // topMenu_RunButton
            // 
            this.topMenu_RunButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_RunButton.Image")));
            this.topMenu_RunButton.Location = new System.Drawing.Point(85, 3);
            this.topMenu_RunButton.Margin = new System.Windows.Forms.Padding(0);
            this.topMenu_RunButton.Name = "topMenu_RunButton";
            this.topMenu_RunButton.Size = new System.Drawing.Size(81, 21);
            this.topMenu_RunButton.TabIndex = 8;
            this.topMenu_RunButton.TabStop = false;
            // 
            // topMenu_StopButton
            // 
            this.topMenu_StopButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_StopButton.Image")));
            this.topMenu_StopButton.Location = new System.Drawing.Point(166, 3);
            this.topMenu_StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.topMenu_StopButton.Name = "topMenu_StopButton";
            this.topMenu_StopButton.Size = new System.Drawing.Size(80, 21);
            this.topMenu_StopButton.TabIndex = 7;
            this.topMenu_StopButton.TabStop = false;
            // 
            // topMenu_SingleButton
            // 
            this.topMenu_SingleButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_SingleButton.Image")));
            this.topMenu_SingleButton.Location = new System.Drawing.Point(246, 3);
            this.topMenu_SingleButton.Margin = new System.Windows.Forms.Padding(0);
            this.topMenu_SingleButton.Name = "topMenu_SingleButton";
            this.topMenu_SingleButton.Size = new System.Drawing.Size(80, 21);
            this.topMenu_SingleButton.TabIndex = 6;
            this.topMenu_SingleButton.TabStop = false;
            // 
            // topMenu_AutoscaleButton
            // 
            this.topMenu_AutoscaleButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_AutoscaleButton.Image")));
            this.topMenu_AutoscaleButton.Location = new System.Drawing.Point(331, 3);
            this.topMenu_AutoscaleButton.Name = "topMenu_AutoscaleButton";
            this.topMenu_AutoscaleButton.Size = new System.Drawing.Size(108, 21);
            this.topMenu_AutoscaleButton.TabIndex = 5;
            this.topMenu_AutoscaleButton.TabStop = false;
            // 
            // topMenu_DefaultButton
            // 
            this.topMenu_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_DefaultButton.Image")));
            this.topMenu_DefaultButton.Location = new System.Drawing.Point(442, 3);
            this.topMenu_DefaultButton.Name = "topMenu_DefaultButton";
            this.topMenu_DefaultButton.Size = new System.Drawing.Size(128, 21);
            this.topMenu_DefaultButton.TabIndex = 4;
            this.topMenu_DefaultButton.TabStop = false;
            // 
            // topMenu_BackButton
            // 
            this.topMenu_BackButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_BackButton.Image")));
            this.topMenu_BackButton.Location = new System.Drawing.Point(575, 3);
            this.topMenu_BackButton.Name = "topMenu_BackButton";
            this.topMenu_BackButton.Size = new System.Drawing.Size(36, 21);
            this.topMenu_BackButton.TabIndex = 3;
            this.topMenu_BackButton.TabStop = false;
            // 
            // topMenu_ForwardButton
            // 
            this.topMenu_ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_ForwardButton.Image")));
            this.topMenu_ForwardButton.Location = new System.Drawing.Point(616, 3);
            this.topMenu_ForwardButton.Name = "topMenu_ForwardButton";
            this.topMenu_ForwardButton.Size = new System.Drawing.Size(36, 21);
            this.topMenu_ForwardButton.TabIndex = 2;
            this.topMenu_ForwardButton.TabStop = false;
            // 
            // topMenu_CopyButton
            // 
            this.topMenu_CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_CopyButton.Image")));
            this.topMenu_CopyButton.Location = new System.Drawing.Point(656, 3);
            this.topMenu_CopyButton.Name = "topMenu_CopyButton";
            this.topMenu_CopyButton.Size = new System.Drawing.Size(78, 21);
            this.topMenu_CopyButton.TabIndex = 1;
            this.topMenu_CopyButton.TabStop = false;
            // 
            // topMenu_HelpButton
            // 
            this.topMenu_HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("topMenu_HelpButton.Image")));
            this.topMenu_HelpButton.Location = new System.Drawing.Point(736, 3);
            this.topMenu_HelpButton.Name = "topMenu_HelpButton";
            this.topMenu_HelpButton.Size = new System.Drawing.Size(70, 21);
            this.topMenu_HelpButton.TabIndex = 0;
            this.topMenu_HelpButton.TabStop = false;
            // 
            // measurementsPanel
            // 
            this.measurementsPanel.BackColor = System.Drawing.Color.Black;
            this.measurementsPanel.Controls.Add(this.measurementArea_MinButton);
            this.measurementsPanel.Controls.Add(this.measurementArea_MidButton);
            this.measurementsPanel.Controls.Add(this.measurementArea_MaxButton);
            this.measurementsPanel.Controls.Add(this.measurementArea_AutoButton);
            this.measurementsPanel.Controls.Add(this.measurementArea_ScalesButton);
            this.measurementsPanel.Controls.Add(this.measurementArea_VerticalScale);
            this.measurementsPanel.Controls.Add(this.measurementArea_OffsetPosition);
            this.measurementsPanel.Controls.Add(this.measurementArea_DelayPosition);
            this.measurementsPanel.Controls.Add(this.measurementArea_HorizontalScale);
            this.measurementsPanel.Controls.Add(this.measurementArea_DelayPosition_4ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_DelayPosition_3ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_HorizontalScale_4ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_HorizontalScale_3ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_OffsetPosition_4ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_OffsetPosition_3ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_VerticalScale_4ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_VerticalScale_3ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_ChannelFour);
            this.measurementsPanel.Controls.Add(this.measurementArea_ChannelThree);
            this.measurementsPanel.Controls.Add(this.measurementArea_DelayPosition_2ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_HorizontalScale_2ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_OffsetPosition_2ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_VerticalScale_2ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_ChannelTwo);
            this.measurementsPanel.Controls.Add(this.measurementArea_DelayPosition_1ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_HorizontalScale_1ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_OffsetPosition_1ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_VerticalScale_1ch);
            this.measurementsPanel.Controls.Add(this.measurementArea_ChannelOne);
            this.measurementsPanel.Controls.Add(this.measurementAreaScale);
            this.measurementsPanel.Controls.Add(this.iconPanel);
            this.measurementsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.measurementsPanel.Location = new System.Drawing.Point(0, 415);
            this.measurementsPanel.Name = "measurementsPanel";
            this.measurementsPanel.Size = new System.Drawing.Size(1040, 116);
            this.measurementsPanel.TabIndex = 14;
            // 
            // measurementArea_MinButton
            // 
            this.measurementArea_MinButton.Image = ((System.Drawing.Image)(resources.GetObject("measurementArea_MinButton.Image")));
            this.measurementArea_MinButton.Location = new System.Drawing.Point(767, 5);
            this.measurementArea_MinButton.Name = "measurementArea_MinButton";
            this.measurementArea_MinButton.Size = new System.Drawing.Size(30, 18);
            this.measurementArea_MinButton.TabIndex = 30;
            this.measurementArea_MinButton.TabStop = false;
            // 
            // measurementArea_MidButton
            // 
            this.measurementArea_MidButton.Image = ((System.Drawing.Image)(resources.GetObject("measurementArea_MidButton.Image")));
            this.measurementArea_MidButton.Location = new System.Drawing.Point(735, 5);
            this.measurementArea_MidButton.Name = "measurementArea_MidButton";
            this.measurementArea_MidButton.Size = new System.Drawing.Size(30, 18);
            this.measurementArea_MidButton.TabIndex = 29;
            this.measurementArea_MidButton.TabStop = false;
            // 
            // measurementArea_MaxButton
            // 
            this.measurementArea_MaxButton.Image = ((System.Drawing.Image)(resources.GetObject("measurementArea_MaxButton.Image")));
            this.measurementArea_MaxButton.Location = new System.Drawing.Point(703, 5);
            this.measurementArea_MaxButton.Name = "measurementArea_MaxButton";
            this.measurementArea_MaxButton.Size = new System.Drawing.Size(30, 18);
            this.measurementArea_MaxButton.TabIndex = 28;
            this.measurementArea_MaxButton.TabStop = false;
            // 
            // measurementArea_AutoButton
            // 
            this.measurementArea_AutoButton.Image = ((System.Drawing.Image)(resources.GetObject("measurementArea_AutoButton.Image")));
            this.measurementArea_AutoButton.Location = new System.Drawing.Point(671, 5);
            this.measurementArea_AutoButton.Name = "measurementArea_AutoButton";
            this.measurementArea_AutoButton.Size = new System.Drawing.Size(30, 18);
            this.measurementArea_AutoButton.TabIndex = 27;
            this.measurementArea_AutoButton.TabStop = false;
            // 
            // measurementArea_ScalesButton
            // 
            this.measurementArea_ScalesButton.Image = ((System.Drawing.Image)(resources.GetObject("measurementArea_ScalesButton.Image")));
            this.measurementArea_ScalesButton.Location = new System.Drawing.Point(12, 5);
            this.measurementArea_ScalesButton.Name = "measurementArea_ScalesButton";
            this.measurementArea_ScalesButton.Size = new System.Drawing.Size(46, 18);
            this.measurementArea_ScalesButton.TabIndex = 26;
            this.measurementArea_ScalesButton.TabStop = false;
            // 
            // measurementArea_VerticalScale
            // 
            this.measurementArea_VerticalScale.AutoSize = true;
            this.measurementArea_VerticalScale.BackColor = System.Drawing.Color.Black;
            this.measurementArea_VerticalScale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_VerticalScale.ForeColor = System.Drawing.Color.White;
            this.measurementArea_VerticalScale.Location = new System.Drawing.Point(153, 26);
            this.measurementArea_VerticalScale.Name = "measurementArea_VerticalScale";
            this.measurementArea_VerticalScale.Size = new System.Drawing.Size(80, 14);
            this.measurementArea_VerticalScale.TabIndex = 25;
            this.measurementArea_VerticalScale.Text = "Vertical Scale";
            // 
            // measurementArea_OffsetPosition
            // 
            this.measurementArea_OffsetPosition.AutoSize = true;
            this.measurementArea_OffsetPosition.BackColor = System.Drawing.Color.Black;
            this.measurementArea_OffsetPosition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_OffsetPosition.ForeColor = System.Drawing.Color.White;
            this.measurementArea_OffsetPosition.Location = new System.Drawing.Point(309, 26);
            this.measurementArea_OffsetPosition.Name = "measurementArea_OffsetPosition";
            this.measurementArea_OffsetPosition.Size = new System.Drawing.Size(98, 14);
            this.measurementArea_OffsetPosition.TabIndex = 24;
            this.measurementArea_OffsetPosition.Text = "Offset + Position";
            // 
            // measurementArea_DelayPosition
            // 
            this.measurementArea_DelayPosition.AutoSize = true;
            this.measurementArea_DelayPosition.BackColor = System.Drawing.Color.Black;
            this.measurementArea_DelayPosition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_DelayPosition.ForeColor = System.Drawing.Color.White;
            this.measurementArea_DelayPosition.Location = new System.Drawing.Point(608, 26);
            this.measurementArea_DelayPosition.Name = "measurementArea_DelayPosition";
            this.measurementArea_DelayPosition.Size = new System.Drawing.Size(93, 14);
            this.measurementArea_DelayPosition.TabIndex = 23;
            this.measurementArea_DelayPosition.Text = "Delay + Position";
            // 
            // measurementArea_HorizontalScale
            // 
            this.measurementArea_HorizontalScale.AutoSize = true;
            this.measurementArea_HorizontalScale.BackColor = System.Drawing.Color.Black;
            this.measurementArea_HorizontalScale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_HorizontalScale.ForeColor = System.Drawing.Color.White;
            this.measurementArea_HorizontalScale.Location = new System.Drawing.Point(466, 26);
            this.measurementArea_HorizontalScale.Name = "measurementArea_HorizontalScale";
            this.measurementArea_HorizontalScale.Size = new System.Drawing.Size(94, 14);
            this.measurementArea_HorizontalScale.TabIndex = 22;
            this.measurementArea_HorizontalScale.Text = "Horizontal Scale";
            // 
            // measurementArea_DelayPosition_4ch
            // 
            this.measurementArea_DelayPosition_4ch.AutoSize = true;
            this.measurementArea_DelayPosition_4ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_DelayPosition_4ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_DelayPosition_4ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.measurementArea_DelayPosition_4ch.Location = new System.Drawing.Point(608, 90);
            this.measurementArea_DelayPosition_4ch.Name = "measurementArea_DelayPosition_4ch";
            this.measurementArea_DelayPosition_4ch.Size = new System.Drawing.Size(40, 14);
            this.measurementArea_DelayPosition_4ch.TabIndex = 21;
            this.measurementArea_DelayPosition_4ch.Text = "-50 ns";
            // 
            // measurementArea_DelayPosition_3ch
            // 
            this.measurementArea_DelayPosition_3ch.AutoSize = true;
            this.measurementArea_DelayPosition_3ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_DelayPosition_3ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_DelayPosition_3ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.measurementArea_DelayPosition_3ch.Location = new System.Drawing.Point(608, 74);
            this.measurementArea_DelayPosition_3ch.Name = "measurementArea_DelayPosition_3ch";
            this.measurementArea_DelayPosition_3ch.Size = new System.Drawing.Size(40, 14);
            this.measurementArea_DelayPosition_3ch.TabIndex = 20;
            this.measurementArea_DelayPosition_3ch.Text = "-50 ns";
            // 
            // measurementArea_HorizontalScale_4ch
            // 
            this.measurementArea_HorizontalScale_4ch.AutoSize = true;
            this.measurementArea_HorizontalScale_4ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_HorizontalScale_4ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_HorizontalScale_4ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.measurementArea_HorizontalScale_4ch.Location = new System.Drawing.Point(466, 90);
            this.measurementArea_HorizontalScale_4ch.Name = "measurementArea_HorizontalScale_4ch";
            this.measurementArea_HorizontalScale_4ch.Size = new System.Drawing.Size(55, 14);
            this.measurementArea_HorizontalScale_4ch.TabIndex = 19;
            this.measurementArea_HorizontalScale_4ch.Text = "10 ns/div";
            // 
            // measurementArea_HorizontalScale_3ch
            // 
            this.measurementArea_HorizontalScale_3ch.AutoSize = true;
            this.measurementArea_HorizontalScale_3ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_HorizontalScale_3ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_HorizontalScale_3ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.measurementArea_HorizontalScale_3ch.Location = new System.Drawing.Point(466, 74);
            this.measurementArea_HorizontalScale_3ch.Name = "measurementArea_HorizontalScale_3ch";
            this.measurementArea_HorizontalScale_3ch.Size = new System.Drawing.Size(55, 14);
            this.measurementArea_HorizontalScale_3ch.TabIndex = 18;
            this.measurementArea_HorizontalScale_3ch.Text = "10 ns/div";
            // 
            // measurementArea_OffsetPosition_4ch
            // 
            this.measurementArea_OffsetPosition_4ch.AutoSize = true;
            this.measurementArea_OffsetPosition_4ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_OffsetPosition_4ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_OffsetPosition_4ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.measurementArea_OffsetPosition_4ch.Location = new System.Drawing.Point(309, 90);
            this.measurementArea_OffsetPosition_4ch.Name = "measurementArea_OffsetPosition_4ch";
            this.measurementArea_OffsetPosition_4ch.Size = new System.Drawing.Size(24, 14);
            this.measurementArea_OffsetPosition_4ch.TabIndex = 17;
            this.measurementArea_OffsetPosition_4ch.Text = "0 V";
            // 
            // measurementArea_OffsetPosition_3ch
            // 
            this.measurementArea_OffsetPosition_3ch.AutoSize = true;
            this.measurementArea_OffsetPosition_3ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_OffsetPosition_3ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_OffsetPosition_3ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.measurementArea_OffsetPosition_3ch.Location = new System.Drawing.Point(309, 74);
            this.measurementArea_OffsetPosition_3ch.Name = "measurementArea_OffsetPosition_3ch";
            this.measurementArea_OffsetPosition_3ch.Size = new System.Drawing.Size(24, 14);
            this.measurementArea_OffsetPosition_3ch.TabIndex = 16;
            this.measurementArea_OffsetPosition_3ch.Text = "0 V";
            // 
            // measurementArea_VerticalScale_4ch
            // 
            this.measurementArea_VerticalScale_4ch.AutoSize = true;
            this.measurementArea_VerticalScale_4ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_VerticalScale_4ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_VerticalScale_4ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.measurementArea_VerticalScale_4ch.Location = new System.Drawing.Point(153, 90);
            this.measurementArea_VerticalScale_4ch.Name = "measurementArea_VerticalScale_4ch";
            this.measurementArea_VerticalScale_4ch.Size = new System.Drawing.Size(66, 14);
            this.measurementArea_VerticalScale_4ch.TabIndex = 15;
            this.measurementArea_VerticalScale_4ch.Text = "100 mV/div";
            // 
            // measurementArea_VerticalScale_3ch
            // 
            this.measurementArea_VerticalScale_3ch.AutoSize = true;
            this.measurementArea_VerticalScale_3ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_VerticalScale_3ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_VerticalScale_3ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.measurementArea_VerticalScale_3ch.Location = new System.Drawing.Point(153, 74);
            this.measurementArea_VerticalScale_3ch.Name = "measurementArea_VerticalScale_3ch";
            this.measurementArea_VerticalScale_3ch.Size = new System.Drawing.Size(66, 14);
            this.measurementArea_VerticalScale_3ch.TabIndex = 14;
            this.measurementArea_VerticalScale_3ch.Text = "100 mV/div";
            // 
            // measurementArea_ChannelFour
            // 
            this.measurementArea_ChannelFour.AutoSize = true;
            this.measurementArea_ChannelFour.BackColor = System.Drawing.Color.Black;
            this.measurementArea_ChannelFour.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_ChannelFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.measurementArea_ChannelFour.Location = new System.Drawing.Point(5, 90);
            this.measurementArea_ChannelFour.Name = "measurementArea_ChannelFour";
            this.measurementArea_ChannelFour.Size = new System.Drawing.Size(61, 14);
            this.measurementArea_ChannelFour.TabIndex = 13;
            this.measurementArea_ChannelFour.Text = "Channel 4";
            // 
            // measurementArea_ChannelThree
            // 
            this.measurementArea_ChannelThree.AutoSize = true;
            this.measurementArea_ChannelThree.BackColor = System.Drawing.Color.Black;
            this.measurementArea_ChannelThree.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_ChannelThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.measurementArea_ChannelThree.Location = new System.Drawing.Point(5, 74);
            this.measurementArea_ChannelThree.Name = "measurementArea_ChannelThree";
            this.measurementArea_ChannelThree.Size = new System.Drawing.Size(61, 14);
            this.measurementArea_ChannelThree.TabIndex = 12;
            this.measurementArea_ChannelThree.Text = "Channel 3";
            // 
            // measurementArea_DelayPosition_2ch
            // 
            this.measurementArea_DelayPosition_2ch.AutoSize = true;
            this.measurementArea_DelayPosition_2ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_DelayPosition_2ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_DelayPosition_2ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.measurementArea_DelayPosition_2ch.Location = new System.Drawing.Point(608, 58);
            this.measurementArea_DelayPosition_2ch.Name = "measurementArea_DelayPosition_2ch";
            this.measurementArea_DelayPosition_2ch.Size = new System.Drawing.Size(40, 14);
            this.measurementArea_DelayPosition_2ch.TabIndex = 11;
            this.measurementArea_DelayPosition_2ch.Text = "-50 ns";
            // 
            // measurementArea_HorizontalScale_2ch
            // 
            this.measurementArea_HorizontalScale_2ch.AutoSize = true;
            this.measurementArea_HorizontalScale_2ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_HorizontalScale_2ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_HorizontalScale_2ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.measurementArea_HorizontalScale_2ch.Location = new System.Drawing.Point(466, 58);
            this.measurementArea_HorizontalScale_2ch.Name = "measurementArea_HorizontalScale_2ch";
            this.measurementArea_HorizontalScale_2ch.Size = new System.Drawing.Size(55, 14);
            this.measurementArea_HorizontalScale_2ch.TabIndex = 10;
            this.measurementArea_HorizontalScale_2ch.Text = "10 ns/div";
            // 
            // measurementArea_OffsetPosition_2ch
            // 
            this.measurementArea_OffsetPosition_2ch.AutoSize = true;
            this.measurementArea_OffsetPosition_2ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_OffsetPosition_2ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_OffsetPosition_2ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.measurementArea_OffsetPosition_2ch.Location = new System.Drawing.Point(309, 58);
            this.measurementArea_OffsetPosition_2ch.Name = "measurementArea_OffsetPosition_2ch";
            this.measurementArea_OffsetPosition_2ch.Size = new System.Drawing.Size(24, 14);
            this.measurementArea_OffsetPosition_2ch.TabIndex = 9;
            this.measurementArea_OffsetPosition_2ch.Text = "0 V";
            // 
            // measurementArea_VerticalScale_2ch
            // 
            this.measurementArea_VerticalScale_2ch.AutoSize = true;
            this.measurementArea_VerticalScale_2ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_VerticalScale_2ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_VerticalScale_2ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.measurementArea_VerticalScale_2ch.Location = new System.Drawing.Point(153, 58);
            this.measurementArea_VerticalScale_2ch.Name = "measurementArea_VerticalScale_2ch";
            this.measurementArea_VerticalScale_2ch.Size = new System.Drawing.Size(66, 14);
            this.measurementArea_VerticalScale_2ch.TabIndex = 8;
            this.measurementArea_VerticalScale_2ch.Text = "100 mV/div";
            // 
            // measurementArea_ChannelTwo
            // 
            this.measurementArea_ChannelTwo.AutoSize = true;
            this.measurementArea_ChannelTwo.BackColor = System.Drawing.Color.Black;
            this.measurementArea_ChannelTwo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_ChannelTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.measurementArea_ChannelTwo.Location = new System.Drawing.Point(5, 58);
            this.measurementArea_ChannelTwo.Name = "measurementArea_ChannelTwo";
            this.measurementArea_ChannelTwo.Size = new System.Drawing.Size(61, 14);
            this.measurementArea_ChannelTwo.TabIndex = 7;
            this.measurementArea_ChannelTwo.Text = "Channel 2";
            // 
            // measurementArea_DelayPosition_1ch
            // 
            this.measurementArea_DelayPosition_1ch.AutoSize = true;
            this.measurementArea_DelayPosition_1ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_DelayPosition_1ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_DelayPosition_1ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.measurementArea_DelayPosition_1ch.Location = new System.Drawing.Point(608, 42);
            this.measurementArea_DelayPosition_1ch.Name = "measurementArea_DelayPosition_1ch";
            this.measurementArea_DelayPosition_1ch.Size = new System.Drawing.Size(40, 14);
            this.measurementArea_DelayPosition_1ch.TabIndex = 6;
            this.measurementArea_DelayPosition_1ch.Text = "-50 ns";
            // 
            // measurementArea_HorizontalScale_1ch
            // 
            this.measurementArea_HorizontalScale_1ch.AutoSize = true;
            this.measurementArea_HorizontalScale_1ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_HorizontalScale_1ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_HorizontalScale_1ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.measurementArea_HorizontalScale_1ch.Location = new System.Drawing.Point(466, 42);
            this.measurementArea_HorizontalScale_1ch.Name = "measurementArea_HorizontalScale_1ch";
            this.measurementArea_HorizontalScale_1ch.Size = new System.Drawing.Size(55, 14);
            this.measurementArea_HorizontalScale_1ch.TabIndex = 5;
            this.measurementArea_HorizontalScale_1ch.Text = "10 ns/div";
            // 
            // measurementArea_OffsetPosition_1ch
            // 
            this.measurementArea_OffsetPosition_1ch.AutoSize = true;
            this.measurementArea_OffsetPosition_1ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_OffsetPosition_1ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_OffsetPosition_1ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.measurementArea_OffsetPosition_1ch.Location = new System.Drawing.Point(309, 42);
            this.measurementArea_OffsetPosition_1ch.Name = "measurementArea_OffsetPosition_1ch";
            this.measurementArea_OffsetPosition_1ch.Size = new System.Drawing.Size(24, 14);
            this.measurementArea_OffsetPosition_1ch.TabIndex = 4;
            this.measurementArea_OffsetPosition_1ch.Text = "0 V";
            // 
            // measurementArea_VerticalScale_1ch
            // 
            this.measurementArea_VerticalScale_1ch.AutoSize = true;
            this.measurementArea_VerticalScale_1ch.BackColor = System.Drawing.Color.Black;
            this.measurementArea_VerticalScale_1ch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_VerticalScale_1ch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.measurementArea_VerticalScale_1ch.Location = new System.Drawing.Point(153, 42);
            this.measurementArea_VerticalScale_1ch.Name = "measurementArea_VerticalScale_1ch";
            this.measurementArea_VerticalScale_1ch.Size = new System.Drawing.Size(66, 14);
            this.measurementArea_VerticalScale_1ch.TabIndex = 3;
            this.measurementArea_VerticalScale_1ch.Text = "100 mV/div";
            // 
            // measurementArea_ChannelOne
            // 
            this.measurementArea_ChannelOne.AutoSize = true;
            this.measurementArea_ChannelOne.BackColor = System.Drawing.Color.Black;
            this.measurementArea_ChannelOne.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementArea_ChannelOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.measurementArea_ChannelOne.Location = new System.Drawing.Point(5, 42);
            this.measurementArea_ChannelOne.Name = "measurementArea_ChannelOne";
            this.measurementArea_ChannelOne.Size = new System.Drawing.Size(61, 14);
            this.measurementArea_ChannelOne.TabIndex = 2;
            this.measurementArea_ChannelOne.Text = "Channel 1";
            // 
            // measurementAreaScale
            // 
            this.measurementAreaScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.measurementAreaScale.Image = ((System.Drawing.Image)(resources.GetObject("measurementAreaScale.Image")));
            this.measurementAreaScale.Location = new System.Drawing.Point(0, 15);
            this.measurementAreaScale.Margin = new System.Windows.Forms.Padding(0);
            this.measurementAreaScale.Name = "measurementAreaScale";
            this.measurementAreaScale.Size = new System.Drawing.Size(807, 99);
            this.measurementAreaScale.TabIndex = 1;
            this.measurementAreaScale.TabStop = false;
            // 
            // iconPanel
            // 
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPanel.Image = ((System.Drawing.Image)(resources.GetObject("iconPanel.Image")));
            this.iconPanel.Location = new System.Drawing.Point(801, 0);
            this.iconPanel.Margin = new System.Windows.Forms.Padding(0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(239, 116);
            this.iconPanel.TabIndex = 0;
            this.iconPanel.TabStop = false;
            // 
            // permanentControlsPanel
            // 
            this.permanentControlsPanel.Controls.Add(this.triggerLevel_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.triggerLevel_TextBox);
            this.permanentControlsPanel.Controls.Add(this.triggerLevel_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.triggerLevel_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.triggerLevel_ZeroButton);
            this.permanentControlsPanel.Controls.Add(this.triggerLevel_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.triggerLevel_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.triggerMode_TriggeredButton);
            this.permanentControlsPanel.Controls.Add(this.triggerMode_FreerunButton);
            this.permanentControlsPanel.Controls.Add(this.triggerSlope_Bislope);
            this.permanentControlsPanel.Controls.Add(this.triggerSlope_Negative);
            this.permanentControlsPanel.Controls.Add(this.triggerSlope_Positive);
            this.permanentControlsPanel.Controls.Add(this.triggerSource_ChannelFour);
            this.permanentControlsPanel.Controls.Add(this.triggerSource_ChannelThree);
            this.permanentControlsPanel.Controls.Add(this.triggerSource_ChannelTwo);
            this.permanentControlsPanel.Controls.Add(this.triggerSource_ChannelOne);
            this.permanentControlsPanel.Controls.Add(this.timebase_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.timebase_BigRightButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_BigLeftButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_SmallRightButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_SmallLeftButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_TextBox);
            this.permanentControlsPanel.Controls.Add(this.timebase_PosDelay_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.timebase_PosDelay_BigRightButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_PosDelay_BigLeftButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_PosDelay_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_PosDelay_SmallRightButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_PosDelay_SmallLeftButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_PosDelay_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_OffsetButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PositionButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_OffsetButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PositionButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_OffsetButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PositionButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_OffsetButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PositionButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PosOfs_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PosOfs_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PosOfs_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PosOfs_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PosOfs_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PosOfs_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_PosOfs_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PosOfs_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PosOfs_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PosOfs_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PosOfs_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PosOfs_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PosOfs_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_PosOfs_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PosOfs_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PosOfs_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PosOfs_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PosOfs_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PosOfs_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PosOfs_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_PosOfs_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PosOfs_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PosOfs_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PosOfs_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PosOfs_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PosOfs_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PosOfs_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_PosOfs_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelFour_Button);
            this.permanentControlsPanel.Controls.Add(this.ChannelThree_Button);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_StatusBar);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_TextBox);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_BigUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_BigDownButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_DefaultButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_SmallUpButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_SmallDownButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_DelayButton);
            this.permanentControlsPanel.Controls.Add(this.timebase_PositionButton);
            this.permanentControlsPanel.Controls.Add(this.ChannelTwo_Button);
            this.permanentControlsPanel.Controls.Add(this.ChannelOne_Button);
            this.permanentControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.permanentControlsPanel.Location = new System.Drawing.Point(0, 531);
            this.permanentControlsPanel.Name = "permanentControlsPanel";
            this.permanentControlsPanel.Size = new System.Drawing.Size(1040, 94);
            this.permanentControlsPanel.TabIndex = 13;
            // 
            // triggerLevel_StatusBar
            // 
            this.triggerLevel_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("triggerLevel_StatusBar.Image")));
            this.triggerLevel_StatusBar.Location = new System.Drawing.Point(710, 24);
            this.triggerLevel_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.triggerLevel_StatusBar.Name = "triggerLevel_StatusBar";
            this.triggerLevel_StatusBar.Size = new System.Drawing.Size(90, 5);
            this.triggerLevel_StatusBar.TabIndex = 99;
            this.triggerLevel_StatusBar.TabStop = false;
            // 
            // triggerLevel_TextBox
            // 
            this.triggerLevel_TextBox.BackColor = System.Drawing.Color.Black;
            this.triggerLevel_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triggerLevel_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerLevel_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.triggerLevel_TextBox.Location = new System.Drawing.Point(710, 6);
            this.triggerLevel_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.triggerLevel_TextBox.Name = "triggerLevel_TextBox";
            this.triggerLevel_TextBox.ReadOnly = true;
            this.triggerLevel_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.triggerLevel_TextBox.Size = new System.Drawing.Size(90, 20);
            this.triggerLevel_TextBox.TabIndex = 98;
            this.triggerLevel_TextBox.Text = " 0 V";
            // 
            // triggerLevel_BigUpButton
            // 
            this.triggerLevel_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("triggerLevel_BigUpButton.Image")));
            this.triggerLevel_BigUpButton.Location = new System.Drawing.Point(780, 29);
            this.triggerLevel_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.triggerLevel_BigUpButton.Name = "triggerLevel_BigUpButton";
            this.triggerLevel_BigUpButton.Size = new System.Drawing.Size(21, 18);
            this.triggerLevel_BigUpButton.TabIndex = 97;
            this.triggerLevel_BigUpButton.TabStop = false;
            // 
            // triggerLevel_BigDownButton
            // 
            this.triggerLevel_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("triggerLevel_BigDownButton.Image")));
            this.triggerLevel_BigDownButton.Location = new System.Drawing.Point(761, 29);
            this.triggerLevel_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.triggerLevel_BigDownButton.Name = "triggerLevel_BigDownButton";
            this.triggerLevel_BigDownButton.Size = new System.Drawing.Size(21, 18);
            this.triggerLevel_BigDownButton.TabIndex = 96;
            this.triggerLevel_BigDownButton.TabStop = false;
            // 
            // triggerLevel_ZeroButton
            // 
            this.triggerLevel_ZeroButton.Image = ((System.Drawing.Image)(resources.GetObject("triggerLevel_ZeroButton.Image")));
            this.triggerLevel_ZeroButton.Location = new System.Drawing.Point(748, 29);
            this.triggerLevel_ZeroButton.Margin = new System.Windows.Forms.Padding(0);
            this.triggerLevel_ZeroButton.Name = "triggerLevel_ZeroButton";
            this.triggerLevel_ZeroButton.Size = new System.Drawing.Size(14, 18);
            this.triggerLevel_ZeroButton.TabIndex = 95;
            this.triggerLevel_ZeroButton.TabStop = false;
            // 
            // triggerLevel_SmallUpButton
            // 
            this.triggerLevel_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("triggerLevel_SmallUpButton.Image")));
            this.triggerLevel_SmallUpButton.Location = new System.Drawing.Point(729, 29);
            this.triggerLevel_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.triggerLevel_SmallUpButton.Name = "triggerLevel_SmallUpButton";
            this.triggerLevel_SmallUpButton.Size = new System.Drawing.Size(21, 18);
            this.triggerLevel_SmallUpButton.TabIndex = 94;
            this.triggerLevel_SmallUpButton.TabStop = false;
            // 
            // triggerLevel_SmallDownButton
            // 
            this.triggerLevel_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("triggerLevel_SmallDownButton.Image")));
            this.triggerLevel_SmallDownButton.Location = new System.Drawing.Point(710, 29);
            this.triggerLevel_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.triggerLevel_SmallDownButton.Name = "triggerLevel_SmallDownButton";
            this.triggerLevel_SmallDownButton.Size = new System.Drawing.Size(21, 18);
            this.triggerLevel_SmallDownButton.TabIndex = 93;
            this.triggerLevel_SmallDownButton.TabStop = false;
            // 
            // triggerMode_TriggeredButton
            // 
            this.triggerMode_TriggeredButton.Image = ((System.Drawing.Image)(resources.GetObject("triggerMode_TriggeredButton.Image")));
            this.triggerMode_TriggeredButton.Location = new System.Drawing.Point(757, 51);
            this.triggerMode_TriggeredButton.Name = "triggerMode_TriggeredButton";
            this.triggerMode_TriggeredButton.Size = new System.Drawing.Size(47, 19);
            this.triggerMode_TriggeredButton.TabIndex = 92;
            this.triggerMode_TriggeredButton.TabStop = false;
            // 
            // triggerMode_FreerunButton
            // 
            this.triggerMode_FreerunButton.Image = ((System.Drawing.Image)(resources.GetObject("triggerMode_FreerunButton.Image")));
            this.triggerMode_FreerunButton.Location = new System.Drawing.Point(710, 51);
            this.triggerMode_FreerunButton.Name = "triggerMode_FreerunButton";
            this.triggerMode_FreerunButton.Size = new System.Drawing.Size(48, 19);
            this.triggerMode_FreerunButton.TabIndex = 91;
            this.triggerMode_FreerunButton.TabStop = false;
            // 
            // triggerSlope_Bislope
            // 
            this.triggerSlope_Bislope.Image = ((System.Drawing.Image)(resources.GetObject("triggerSlope_Bislope.Image")));
            this.triggerSlope_Bislope.Location = new System.Drawing.Point(757, 74);
            this.triggerSlope_Bislope.Name = "triggerSlope_Bislope";
            this.triggerSlope_Bislope.Size = new System.Drawing.Size(47, 19);
            this.triggerSlope_Bislope.TabIndex = 90;
            this.triggerSlope_Bislope.TabStop = false;
            // 
            // triggerSlope_Negative
            // 
            this.triggerSlope_Negative.Image = ((System.Drawing.Image)(resources.GetObject("triggerSlope_Negative.Image")));
            this.triggerSlope_Negative.Location = new System.Drawing.Point(711, 74);
            this.triggerSlope_Negative.Name = "triggerSlope_Negative";
            this.triggerSlope_Negative.Size = new System.Drawing.Size(47, 19);
            this.triggerSlope_Negative.TabIndex = 89;
            this.triggerSlope_Negative.TabStop = false;
            // 
            // triggerSlope_Positive
            // 
            this.triggerSlope_Positive.Image = ((System.Drawing.Image)(resources.GetObject("triggerSlope_Positive.Image")));
            this.triggerSlope_Positive.Location = new System.Drawing.Point(665, 74);
            this.triggerSlope_Positive.Name = "triggerSlope_Positive";
            this.triggerSlope_Positive.Size = new System.Drawing.Size(47, 19);
            this.triggerSlope_Positive.TabIndex = 88;
            this.triggerSlope_Positive.TabStop = false;
            // 
            // triggerSource_ChannelFour
            // 
            this.triggerSource_ChannelFour.Image = ((System.Drawing.Image)(resources.GetObject("triggerSource_ChannelFour.Image")));
            this.triggerSource_ChannelFour.Location = new System.Drawing.Point(665, 54);
            this.triggerSource_ChannelFour.Name = "triggerSource_ChannelFour";
            this.triggerSource_ChannelFour.Size = new System.Drawing.Size(41, 17);
            this.triggerSource_ChannelFour.TabIndex = 87;
            this.triggerSource_ChannelFour.TabStop = false;
            // 
            // triggerSource_ChannelThree
            // 
            this.triggerSource_ChannelThree.Image = ((System.Drawing.Image)(resources.GetObject("triggerSource_ChannelThree.Image")));
            this.triggerSource_ChannelThree.Location = new System.Drawing.Point(665, 38);
            this.triggerSource_ChannelThree.Name = "triggerSource_ChannelThree";
            this.triggerSource_ChannelThree.Size = new System.Drawing.Size(41, 17);
            this.triggerSource_ChannelThree.TabIndex = 86;
            this.triggerSource_ChannelThree.TabStop = false;
            // 
            // triggerSource_ChannelTwo
            // 
            this.triggerSource_ChannelTwo.Image = ((System.Drawing.Image)(resources.GetObject("triggerSource_ChannelTwo.Image")));
            this.triggerSource_ChannelTwo.Location = new System.Drawing.Point(665, 22);
            this.triggerSource_ChannelTwo.Name = "triggerSource_ChannelTwo";
            this.triggerSource_ChannelTwo.Size = new System.Drawing.Size(41, 17);
            this.triggerSource_ChannelTwo.TabIndex = 85;
            this.triggerSource_ChannelTwo.TabStop = false;
            // 
            // triggerSource_ChannelOne
            // 
            this.triggerSource_ChannelOne.Image = ((System.Drawing.Image)(resources.GetObject("triggerSource_ChannelOne.Image")));
            this.triggerSource_ChannelOne.Location = new System.Drawing.Point(665, 6);
            this.triggerSource_ChannelOne.Name = "triggerSource_ChannelOne";
            this.triggerSource_ChannelOne.Size = new System.Drawing.Size(41, 17);
            this.triggerSource_ChannelOne.TabIndex = 84;
            this.triggerSource_ChannelOne.TabStop = false;
            // 
            // timebase_StatusBar
            // 
            this.timebase_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("timebase_StatusBar.Image")));
            this.timebase_StatusBar.Location = new System.Drawing.Point(562, 25);
            this.timebase_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_StatusBar.Name = "timebase_StatusBar";
            this.timebase_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.timebase_StatusBar.TabIndex = 83;
            this.timebase_StatusBar.TabStop = false;
            // 
            // timebase_BigRightButton
            // 
            this.timebase_BigRightButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_BigRightButton.Image")));
            this.timebase_BigRightButton.Location = new System.Drawing.Point(634, 29);
            this.timebase_BigRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_BigRightButton.Name = "timebase_BigRightButton";
            this.timebase_BigRightButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_BigRightButton.TabIndex = 82;
            this.timebase_BigRightButton.TabStop = false;
            // 
            // timebase_BigLeftButton
            // 
            this.timebase_BigLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_BigLeftButton.Image")));
            this.timebase_BigLeftButton.Location = new System.Drawing.Point(615, 29);
            this.timebase_BigLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_BigLeftButton.Name = "timebase_BigLeftButton";
            this.timebase_BigLeftButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_BigLeftButton.TabIndex = 81;
            this.timebase_BigLeftButton.TabStop = false;
            // 
            // timebase_DefaultButton
            // 
            this.timebase_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_DefaultButton.Image")));
            this.timebase_DefaultButton.Location = new System.Drawing.Point(600, 29);
            this.timebase_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_DefaultButton.Name = "timebase_DefaultButton";
            this.timebase_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.timebase_DefaultButton.TabIndex = 80;
            this.timebase_DefaultButton.TabStop = false;
            // 
            // timebase_SmallRightButton
            // 
            this.timebase_SmallRightButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_SmallRightButton.Image")));
            this.timebase_SmallRightButton.Location = new System.Drawing.Point(581, 29);
            this.timebase_SmallRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_SmallRightButton.Name = "timebase_SmallRightButton";
            this.timebase_SmallRightButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_SmallRightButton.TabIndex = 79;
            this.timebase_SmallRightButton.TabStop = false;
            // 
            // timebase_SmallLeftButton
            // 
            this.timebase_SmallLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_SmallLeftButton.Image")));
            this.timebase_SmallLeftButton.Location = new System.Drawing.Point(562, 29);
            this.timebase_SmallLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_SmallLeftButton.Name = "timebase_SmallLeftButton";
            this.timebase_SmallLeftButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_SmallLeftButton.TabIndex = 78;
            this.timebase_SmallLeftButton.TabStop = false;
            // 
            // timebase_TextBox
            // 
            this.timebase_TextBox.BackColor = System.Drawing.Color.Black;
            this.timebase_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timebase_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timebase_TextBox.ForeColor = System.Drawing.Color.White;
            this.timebase_TextBox.Location = new System.Drawing.Point(562, 6);
            this.timebase_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_TextBox.Name = "timebase_TextBox";
            this.timebase_TextBox.ReadOnly = true;
            this.timebase_TextBox.Size = new System.Drawing.Size(92, 20);
            this.timebase_TextBox.TabIndex = 77;
            this.timebase_TextBox.Text = "10 ns/div";
            // 
            // timebase_PosDelay_StatusBar
            // 
            this.timebase_PosDelay_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("timebase_PosDelay_StatusBar.Image")));
            this.timebase_PosDelay_StatusBar.Location = new System.Drawing.Point(562, 71);
            this.timebase_PosDelay_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PosDelay_StatusBar.Name = "timebase_PosDelay_StatusBar";
            this.timebase_PosDelay_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.timebase_PosDelay_StatusBar.TabIndex = 76;
            this.timebase_PosDelay_StatusBar.TabStop = false;
            // 
            // timebase_PosDelay_BigRightButton
            // 
            this.timebase_PosDelay_BigRightButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_PosDelay_BigRightButton.Image")));
            this.timebase_PosDelay_BigRightButton.Location = new System.Drawing.Point(634, 75);
            this.timebase_PosDelay_BigRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PosDelay_BigRightButton.Name = "timebase_PosDelay_BigRightButton";
            this.timebase_PosDelay_BigRightButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_PosDelay_BigRightButton.TabIndex = 75;
            this.timebase_PosDelay_BigRightButton.TabStop = false;
            // 
            // timebase_PosDelay_BigLeftButton
            // 
            this.timebase_PosDelay_BigLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_PosDelay_BigLeftButton.Image")));
            this.timebase_PosDelay_BigLeftButton.Location = new System.Drawing.Point(615, 75);
            this.timebase_PosDelay_BigLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PosDelay_BigLeftButton.Name = "timebase_PosDelay_BigLeftButton";
            this.timebase_PosDelay_BigLeftButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_PosDelay_BigLeftButton.TabIndex = 74;
            this.timebase_PosDelay_BigLeftButton.TabStop = false;
            // 
            // timebase_PosDelay_DefaultButton
            // 
            this.timebase_PosDelay_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_PosDelay_DefaultButton.Image")));
            this.timebase_PosDelay_DefaultButton.Location = new System.Drawing.Point(600, 75);
            this.timebase_PosDelay_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PosDelay_DefaultButton.Name = "timebase_PosDelay_DefaultButton";
            this.timebase_PosDelay_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.timebase_PosDelay_DefaultButton.TabIndex = 73;
            this.timebase_PosDelay_DefaultButton.TabStop = false;
            // 
            // timebase_PosDelay_SmallRightButton
            // 
            this.timebase_PosDelay_SmallRightButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_PosDelay_SmallRightButton.Image")));
            this.timebase_PosDelay_SmallRightButton.Location = new System.Drawing.Point(581, 75);
            this.timebase_PosDelay_SmallRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PosDelay_SmallRightButton.Name = "timebase_PosDelay_SmallRightButton";
            this.timebase_PosDelay_SmallRightButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_PosDelay_SmallRightButton.TabIndex = 72;
            this.timebase_PosDelay_SmallRightButton.TabStop = false;
            // 
            // timebase_PosDelay_SmallLeftButton
            // 
            this.timebase_PosDelay_SmallLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_PosDelay_SmallLeftButton.Image")));
            this.timebase_PosDelay_SmallLeftButton.Location = new System.Drawing.Point(562, 75);
            this.timebase_PosDelay_SmallLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PosDelay_SmallLeftButton.Name = "timebase_PosDelay_SmallLeftButton";
            this.timebase_PosDelay_SmallLeftButton.Size = new System.Drawing.Size(20, 18);
            this.timebase_PosDelay_SmallLeftButton.TabIndex = 71;
            this.timebase_PosDelay_SmallLeftButton.TabStop = false;
            // 
            // timebase_PosDelay_TextBox
            // 
            this.timebase_PosDelay_TextBox.BackColor = System.Drawing.Color.Black;
            this.timebase_PosDelay_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timebase_PosDelay_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timebase_PosDelay_TextBox.ForeColor = System.Drawing.Color.White;
            this.timebase_PosDelay_TextBox.Location = new System.Drawing.Point(562, 52);
            this.timebase_PosDelay_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PosDelay_TextBox.Name = "timebase_PosDelay_TextBox";
            this.timebase_PosDelay_TextBox.ReadOnly = true;
            this.timebase_PosDelay_TextBox.Size = new System.Drawing.Size(92, 20);
            this.timebase_PosDelay_TextBox.TabIndex = 70;
            this.timebase_PosDelay_TextBox.Text = "50 %";
            // 
            // ChannelFour_OffsetButton
            // 
            this.ChannelFour_OffsetButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_OffsetButton.Image")));
            this.ChannelFour_OffsetButton.Location = new System.Drawing.Point(390, 73);
            this.ChannelFour_OffsetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_OffsetButton.Name = "ChannelFour_OffsetButton";
            this.ChannelFour_OffsetButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelFour_OffsetButton.TabIndex = 69;
            this.ChannelFour_OffsetButton.TabStop = false;
            // 
            // ChannelFour_PositionButton
            // 
            this.ChannelFour_PositionButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_PositionButton.Image")));
            this.ChannelFour_PositionButton.Location = new System.Drawing.Point(390, 58);
            this.ChannelFour_PositionButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PositionButton.Name = "ChannelFour_PositionButton";
            this.ChannelFour_PositionButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelFour_PositionButton.TabIndex = 68;
            this.ChannelFour_PositionButton.TabStop = false;
            // 
            // ChannelThree_OffsetButton
            // 
            this.ChannelThree_OffsetButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_OffsetButton.Image")));
            this.ChannelThree_OffsetButton.Location = new System.Drawing.Point(261, 73);
            this.ChannelThree_OffsetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_OffsetButton.Name = "ChannelThree_OffsetButton";
            this.ChannelThree_OffsetButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelThree_OffsetButton.TabIndex = 67;
            this.ChannelThree_OffsetButton.TabStop = false;
            // 
            // ChannelThree_PositionButton
            // 
            this.ChannelThree_PositionButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_PositionButton.Image")));
            this.ChannelThree_PositionButton.Location = new System.Drawing.Point(261, 58);
            this.ChannelThree_PositionButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PositionButton.Name = "ChannelThree_PositionButton";
            this.ChannelThree_PositionButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelThree_PositionButton.TabIndex = 66;
            this.ChannelThree_PositionButton.TabStop = false;
            // 
            // ChannelTwo_OffsetButton
            // 
            this.ChannelTwo_OffsetButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_OffsetButton.Image")));
            this.ChannelTwo_OffsetButton.Location = new System.Drawing.Point(132, 73);
            this.ChannelTwo_OffsetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_OffsetButton.Name = "ChannelTwo_OffsetButton";
            this.ChannelTwo_OffsetButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelTwo_OffsetButton.TabIndex = 65;
            this.ChannelTwo_OffsetButton.TabStop = false;
            // 
            // ChannelTwo_PositionButton
            // 
            this.ChannelTwo_PositionButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_PositionButton.Image")));
            this.ChannelTwo_PositionButton.Location = new System.Drawing.Point(132, 58);
            this.ChannelTwo_PositionButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PositionButton.Name = "ChannelTwo_PositionButton";
            this.ChannelTwo_PositionButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelTwo_PositionButton.TabIndex = 64;
            this.ChannelTwo_PositionButton.TabStop = false;
            // 
            // ChannelOne_OffsetButton
            // 
            this.ChannelOne_OffsetButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_OffsetButton.Image")));
            this.ChannelOne_OffsetButton.Location = new System.Drawing.Point(3, 73);
            this.ChannelOne_OffsetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_OffsetButton.Name = "ChannelOne_OffsetButton";
            this.ChannelOne_OffsetButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelOne_OffsetButton.TabIndex = 63;
            this.ChannelOne_OffsetButton.TabStop = false;
            // 
            // ChannelOne_PositionButton
            // 
            this.ChannelOne_PositionButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_PositionButton.Image")));
            this.ChannelOne_PositionButton.Location = new System.Drawing.Point(3, 58);
            this.ChannelOne_PositionButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PositionButton.Name = "ChannelOne_PositionButton";
            this.ChannelOne_PositionButton.Size = new System.Drawing.Size(29, 16);
            this.ChannelOne_PositionButton.TabIndex = 62;
            this.ChannelOne_PositionButton.TabStop = false;
            // 
            // ChannelFour_PosOfs_StatusBar
            // 
            this.ChannelFour_PosOfs_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_PosOfs_StatusBar.Image")));
            this.ChannelFour_PosOfs_StatusBar.Location = new System.Drawing.Point(422, 71);
            this.ChannelFour_PosOfs_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PosOfs_StatusBar.Name = "ChannelFour_PosOfs_StatusBar";
            this.ChannelFour_PosOfs_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelFour_PosOfs_StatusBar.TabIndex = 61;
            this.ChannelFour_PosOfs_StatusBar.TabStop = false;
            // 
            // ChannelFour_PosOfs_BigUpButton
            // 
            this.ChannelFour_PosOfs_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_PosOfs_BigUpButton.Image")));
            this.ChannelFour_PosOfs_BigUpButton.Location = new System.Drawing.Point(494, 75);
            this.ChannelFour_PosOfs_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PosOfs_BigUpButton.Name = "ChannelFour_PosOfs_BigUpButton";
            this.ChannelFour_PosOfs_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_PosOfs_BigUpButton.TabIndex = 60;
            this.ChannelFour_PosOfs_BigUpButton.TabStop = false;
            // 
            // ChannelFour_PosOfs_BigDownButton
            // 
            this.ChannelFour_PosOfs_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_PosOfs_BigDownButton.Image")));
            this.ChannelFour_PosOfs_BigDownButton.Location = new System.Drawing.Point(475, 75);
            this.ChannelFour_PosOfs_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PosOfs_BigDownButton.Name = "ChannelFour_PosOfs_BigDownButton";
            this.ChannelFour_PosOfs_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_PosOfs_BigDownButton.TabIndex = 59;
            this.ChannelFour_PosOfs_BigDownButton.TabStop = false;
            // 
            // ChannelFour_PosOfs_DefaultButton
            // 
            this.ChannelFour_PosOfs_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_PosOfs_DefaultButton.Image")));
            this.ChannelFour_PosOfs_DefaultButton.Location = new System.Drawing.Point(460, 75);
            this.ChannelFour_PosOfs_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PosOfs_DefaultButton.Name = "ChannelFour_PosOfs_DefaultButton";
            this.ChannelFour_PosOfs_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelFour_PosOfs_DefaultButton.TabIndex = 58;
            this.ChannelFour_PosOfs_DefaultButton.TabStop = false;
            // 
            // ChannelFour_PosOfs_SmallUpButton
            // 
            this.ChannelFour_PosOfs_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_PosOfs_SmallUpButton.Image")));
            this.ChannelFour_PosOfs_SmallUpButton.Location = new System.Drawing.Point(441, 75);
            this.ChannelFour_PosOfs_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PosOfs_SmallUpButton.Name = "ChannelFour_PosOfs_SmallUpButton";
            this.ChannelFour_PosOfs_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_PosOfs_SmallUpButton.TabIndex = 57;
            this.ChannelFour_PosOfs_SmallUpButton.TabStop = false;
            // 
            // ChannelFour_PosOfs_SmallDownButton
            // 
            this.ChannelFour_PosOfs_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_PosOfs_SmallDownButton.Image")));
            this.ChannelFour_PosOfs_SmallDownButton.Location = new System.Drawing.Point(422, 75);
            this.ChannelFour_PosOfs_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PosOfs_SmallDownButton.Name = "ChannelFour_PosOfs_SmallDownButton";
            this.ChannelFour_PosOfs_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_PosOfs_SmallDownButton.TabIndex = 56;
            this.ChannelFour_PosOfs_SmallDownButton.TabStop = false;
            // 
            // ChannelFour_PosOfs_TextBox
            // 
            this.ChannelFour_PosOfs_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelFour_PosOfs_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelFour_PosOfs_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelFour_PosOfs_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.ChannelFour_PosOfs_TextBox.Location = new System.Drawing.Point(422, 52);
            this.ChannelFour_PosOfs_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_PosOfs_TextBox.Name = "ChannelFour_PosOfs_TextBox";
            this.ChannelFour_PosOfs_TextBox.ReadOnly = true;
            this.ChannelFour_PosOfs_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelFour_PosOfs_TextBox.TabIndex = 55;
            this.ChannelFour_PosOfs_TextBox.Text = "0 div";
            // 
            // ChannelThree_PosOfs_StatusBar
            // 
            this.ChannelThree_PosOfs_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_PosOfs_StatusBar.Image")));
            this.ChannelThree_PosOfs_StatusBar.Location = new System.Drawing.Point(293, 71);
            this.ChannelThree_PosOfs_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PosOfs_StatusBar.Name = "ChannelThree_PosOfs_StatusBar";
            this.ChannelThree_PosOfs_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelThree_PosOfs_StatusBar.TabIndex = 54;
            this.ChannelThree_PosOfs_StatusBar.TabStop = false;
            // 
            // ChannelThree_PosOfs_BigUpButton
            // 
            this.ChannelThree_PosOfs_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_PosOfs_BigUpButton.Image")));
            this.ChannelThree_PosOfs_BigUpButton.Location = new System.Drawing.Point(365, 75);
            this.ChannelThree_PosOfs_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PosOfs_BigUpButton.Name = "ChannelThree_PosOfs_BigUpButton";
            this.ChannelThree_PosOfs_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_PosOfs_BigUpButton.TabIndex = 53;
            this.ChannelThree_PosOfs_BigUpButton.TabStop = false;
            // 
            // ChannelThree_PosOfs_BigDownButton
            // 
            this.ChannelThree_PosOfs_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_PosOfs_BigDownButton.Image")));
            this.ChannelThree_PosOfs_BigDownButton.Location = new System.Drawing.Point(346, 75);
            this.ChannelThree_PosOfs_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PosOfs_BigDownButton.Name = "ChannelThree_PosOfs_BigDownButton";
            this.ChannelThree_PosOfs_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_PosOfs_BigDownButton.TabIndex = 52;
            this.ChannelThree_PosOfs_BigDownButton.TabStop = false;
            // 
            // ChannelThree_PosOfs_DefaultButton
            // 
            this.ChannelThree_PosOfs_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_PosOfs_DefaultButton.Image")));
            this.ChannelThree_PosOfs_DefaultButton.Location = new System.Drawing.Point(331, 75);
            this.ChannelThree_PosOfs_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PosOfs_DefaultButton.Name = "ChannelThree_PosOfs_DefaultButton";
            this.ChannelThree_PosOfs_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelThree_PosOfs_DefaultButton.TabIndex = 51;
            this.ChannelThree_PosOfs_DefaultButton.TabStop = false;
            // 
            // ChannelThree_PosOfs_SmallUpButton
            // 
            this.ChannelThree_PosOfs_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_PosOfs_SmallUpButton.Image")));
            this.ChannelThree_PosOfs_SmallUpButton.Location = new System.Drawing.Point(312, 75);
            this.ChannelThree_PosOfs_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PosOfs_SmallUpButton.Name = "ChannelThree_PosOfs_SmallUpButton";
            this.ChannelThree_PosOfs_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_PosOfs_SmallUpButton.TabIndex = 50;
            this.ChannelThree_PosOfs_SmallUpButton.TabStop = false;
            // 
            // ChannelThree_PosOfs_SmallDownButton
            // 
            this.ChannelThree_PosOfs_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_PosOfs_SmallDownButton.Image")));
            this.ChannelThree_PosOfs_SmallDownButton.Location = new System.Drawing.Point(293, 75);
            this.ChannelThree_PosOfs_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PosOfs_SmallDownButton.Name = "ChannelThree_PosOfs_SmallDownButton";
            this.ChannelThree_PosOfs_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_PosOfs_SmallDownButton.TabIndex = 49;
            this.ChannelThree_PosOfs_SmallDownButton.TabStop = false;
            // 
            // ChannelThree_PosOfs_TextBox
            // 
            this.ChannelThree_PosOfs_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelThree_PosOfs_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelThree_PosOfs_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelThree_PosOfs_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.ChannelThree_PosOfs_TextBox.Location = new System.Drawing.Point(293, 52);
            this.ChannelThree_PosOfs_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_PosOfs_TextBox.Name = "ChannelThree_PosOfs_TextBox";
            this.ChannelThree_PosOfs_TextBox.ReadOnly = true;
            this.ChannelThree_PosOfs_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelThree_PosOfs_TextBox.TabIndex = 48;
            this.ChannelThree_PosOfs_TextBox.Text = "0 div";
            // 
            // ChannelTwo_PosOfs_StatusBar
            // 
            this.ChannelTwo_PosOfs_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_PosOfs_StatusBar.Image")));
            this.ChannelTwo_PosOfs_StatusBar.Location = new System.Drawing.Point(164, 71);
            this.ChannelTwo_PosOfs_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PosOfs_StatusBar.Name = "ChannelTwo_PosOfs_StatusBar";
            this.ChannelTwo_PosOfs_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelTwo_PosOfs_StatusBar.TabIndex = 47;
            this.ChannelTwo_PosOfs_StatusBar.TabStop = false;
            // 
            // ChannelTwo_PosOfs_BigUpButton
            // 
            this.ChannelTwo_PosOfs_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_PosOfs_BigUpButton.Image")));
            this.ChannelTwo_PosOfs_BigUpButton.Location = new System.Drawing.Point(236, 75);
            this.ChannelTwo_PosOfs_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PosOfs_BigUpButton.Name = "ChannelTwo_PosOfs_BigUpButton";
            this.ChannelTwo_PosOfs_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_PosOfs_BigUpButton.TabIndex = 46;
            this.ChannelTwo_PosOfs_BigUpButton.TabStop = false;
            // 
            // ChannelTwo_PosOfs_BigDownButton
            // 
            this.ChannelTwo_PosOfs_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_PosOfs_BigDownButton.Image")));
            this.ChannelTwo_PosOfs_BigDownButton.Location = new System.Drawing.Point(217, 75);
            this.ChannelTwo_PosOfs_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PosOfs_BigDownButton.Name = "ChannelTwo_PosOfs_BigDownButton";
            this.ChannelTwo_PosOfs_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_PosOfs_BigDownButton.TabIndex = 45;
            this.ChannelTwo_PosOfs_BigDownButton.TabStop = false;
            // 
            // ChannelTwo_PosOfs_DefaultButton
            // 
            this.ChannelTwo_PosOfs_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_PosOfs_DefaultButton.Image")));
            this.ChannelTwo_PosOfs_DefaultButton.Location = new System.Drawing.Point(202, 75);
            this.ChannelTwo_PosOfs_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PosOfs_DefaultButton.Name = "ChannelTwo_PosOfs_DefaultButton";
            this.ChannelTwo_PosOfs_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelTwo_PosOfs_DefaultButton.TabIndex = 44;
            this.ChannelTwo_PosOfs_DefaultButton.TabStop = false;
            // 
            // ChannelTwo_PosOfs_SmallUpButton
            // 
            this.ChannelTwo_PosOfs_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_PosOfs_SmallUpButton.Image")));
            this.ChannelTwo_PosOfs_SmallUpButton.Location = new System.Drawing.Point(183, 75);
            this.ChannelTwo_PosOfs_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PosOfs_SmallUpButton.Name = "ChannelTwo_PosOfs_SmallUpButton";
            this.ChannelTwo_PosOfs_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_PosOfs_SmallUpButton.TabIndex = 43;
            this.ChannelTwo_PosOfs_SmallUpButton.TabStop = false;
            // 
            // ChannelTwo_PosOfs_SmallDownButton
            // 
            this.ChannelTwo_PosOfs_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_PosOfs_SmallDownButton.Image")));
            this.ChannelTwo_PosOfs_SmallDownButton.Location = new System.Drawing.Point(164, 75);
            this.ChannelTwo_PosOfs_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PosOfs_SmallDownButton.Name = "ChannelTwo_PosOfs_SmallDownButton";
            this.ChannelTwo_PosOfs_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_PosOfs_SmallDownButton.TabIndex = 42;
            this.ChannelTwo_PosOfs_SmallDownButton.TabStop = false;
            // 
            // ChannelTwo_PosOfs_TextBox
            // 
            this.ChannelTwo_PosOfs_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelTwo_PosOfs_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelTwo_PosOfs_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelTwo_PosOfs_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChannelTwo_PosOfs_TextBox.Location = new System.Drawing.Point(164, 52);
            this.ChannelTwo_PosOfs_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_PosOfs_TextBox.Name = "ChannelTwo_PosOfs_TextBox";
            this.ChannelTwo_PosOfs_TextBox.ReadOnly = true;
            this.ChannelTwo_PosOfs_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelTwo_PosOfs_TextBox.TabIndex = 41;
            this.ChannelTwo_PosOfs_TextBox.Text = "0 div";
            // 
            // ChannelOne_PosOfs_StatusBar
            // 
            this.ChannelOne_PosOfs_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_PosOfs_StatusBar.Image")));
            this.ChannelOne_PosOfs_StatusBar.Location = new System.Drawing.Point(35, 71);
            this.ChannelOne_PosOfs_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PosOfs_StatusBar.Name = "ChannelOne_PosOfs_StatusBar";
            this.ChannelOne_PosOfs_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelOne_PosOfs_StatusBar.TabIndex = 40;
            this.ChannelOne_PosOfs_StatusBar.TabStop = false;
            // 
            // ChannelOne_PosOfs_TextBox
            // 
            this.ChannelOne_PosOfs_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelOne_PosOfs_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelOne_PosOfs_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelOne_PosOfs_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.ChannelOne_PosOfs_TextBox.Location = new System.Drawing.Point(35, 52);
            this.ChannelOne_PosOfs_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PosOfs_TextBox.Name = "ChannelOne_PosOfs_TextBox";
            this.ChannelOne_PosOfs_TextBox.ReadOnly = true;
            this.ChannelOne_PosOfs_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelOne_PosOfs_TextBox.TabIndex = 39;
            this.ChannelOne_PosOfs_TextBox.Text = "0 div";
            // 
            // ChannelOne_PosOfs_BigUpButton
            // 
            this.ChannelOne_PosOfs_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_PosOfs_BigUpButton.Image")));
            this.ChannelOne_PosOfs_BigUpButton.Location = new System.Drawing.Point(107, 75);
            this.ChannelOne_PosOfs_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PosOfs_BigUpButton.Name = "ChannelOne_PosOfs_BigUpButton";
            this.ChannelOne_PosOfs_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_PosOfs_BigUpButton.TabIndex = 38;
            this.ChannelOne_PosOfs_BigUpButton.TabStop = false;
            // 
            // ChannelOne_PosOfs_BigDownButton
            // 
            this.ChannelOne_PosOfs_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_PosOfs_BigDownButton.Image")));
            this.ChannelOne_PosOfs_BigDownButton.Location = new System.Drawing.Point(88, 75);
            this.ChannelOne_PosOfs_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PosOfs_BigDownButton.Name = "ChannelOne_PosOfs_BigDownButton";
            this.ChannelOne_PosOfs_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_PosOfs_BigDownButton.TabIndex = 37;
            this.ChannelOne_PosOfs_BigDownButton.TabStop = false;
            // 
            // ChannelOne_PosOfs_DefaultButton
            // 
            this.ChannelOne_PosOfs_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_PosOfs_DefaultButton.Image")));
            this.ChannelOne_PosOfs_DefaultButton.Location = new System.Drawing.Point(73, 75);
            this.ChannelOne_PosOfs_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PosOfs_DefaultButton.Name = "ChannelOne_PosOfs_DefaultButton";
            this.ChannelOne_PosOfs_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelOne_PosOfs_DefaultButton.TabIndex = 36;
            this.ChannelOne_PosOfs_DefaultButton.TabStop = false;
            // 
            // ChannelOne_PosOfs_SmallUpButton
            // 
            this.ChannelOne_PosOfs_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_PosOfs_SmallUpButton.Image")));
            this.ChannelOne_PosOfs_SmallUpButton.Location = new System.Drawing.Point(54, 75);
            this.ChannelOne_PosOfs_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PosOfs_SmallUpButton.Name = "ChannelOne_PosOfs_SmallUpButton";
            this.ChannelOne_PosOfs_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_PosOfs_SmallUpButton.TabIndex = 35;
            this.ChannelOne_PosOfs_SmallUpButton.TabStop = false;
            // 
            // ChannelOne_PosOfs_SmallDownButton
            // 
            this.ChannelOne_PosOfs_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_PosOfs_SmallDownButton.Image")));
            this.ChannelOne_PosOfs_SmallDownButton.Location = new System.Drawing.Point(35, 75);
            this.ChannelOne_PosOfs_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_PosOfs_SmallDownButton.Name = "ChannelOne_PosOfs_SmallDownButton";
            this.ChannelOne_PosOfs_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_PosOfs_SmallDownButton.TabIndex = 34;
            this.ChannelOne_PosOfs_SmallDownButton.TabStop = false;
            // 
            // ChannelFour_StatusBar
            // 
            this.ChannelFour_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_StatusBar.Image")));
            this.ChannelFour_StatusBar.Location = new System.Drawing.Point(422, 25);
            this.ChannelFour_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_StatusBar.Name = "ChannelFour_StatusBar";
            this.ChannelFour_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelFour_StatusBar.TabIndex = 33;
            this.ChannelFour_StatusBar.TabStop = false;
            // 
            // ChannelFour_BigUpButton
            // 
            this.ChannelFour_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_BigUpButton.Image")));
            this.ChannelFour_BigUpButton.Location = new System.Drawing.Point(494, 29);
            this.ChannelFour_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_BigUpButton.Name = "ChannelFour_BigUpButton";
            this.ChannelFour_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_BigUpButton.TabIndex = 32;
            this.ChannelFour_BigUpButton.TabStop = false;
            // 
            // ChannelFour_BigDownButton
            // 
            this.ChannelFour_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_BigDownButton.Image")));
            this.ChannelFour_BigDownButton.Location = new System.Drawing.Point(475, 29);
            this.ChannelFour_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_BigDownButton.Name = "ChannelFour_BigDownButton";
            this.ChannelFour_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_BigDownButton.TabIndex = 31;
            this.ChannelFour_BigDownButton.TabStop = false;
            // 
            // ChannelFour_DefaultButton
            // 
            this.ChannelFour_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_DefaultButton.Image")));
            this.ChannelFour_DefaultButton.Location = new System.Drawing.Point(460, 29);
            this.ChannelFour_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_DefaultButton.Name = "ChannelFour_DefaultButton";
            this.ChannelFour_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelFour_DefaultButton.TabIndex = 30;
            this.ChannelFour_DefaultButton.TabStop = false;
            // 
            // ChannelFour_SmallUpButton
            // 
            this.ChannelFour_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_SmallUpButton.Image")));
            this.ChannelFour_SmallUpButton.Location = new System.Drawing.Point(441, 29);
            this.ChannelFour_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_SmallUpButton.Name = "ChannelFour_SmallUpButton";
            this.ChannelFour_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_SmallUpButton.TabIndex = 29;
            this.ChannelFour_SmallUpButton.TabStop = false;
            // 
            // ChannelFour_SmallDownButton
            // 
            this.ChannelFour_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_SmallDownButton.Image")));
            this.ChannelFour_SmallDownButton.Location = new System.Drawing.Point(422, 29);
            this.ChannelFour_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_SmallDownButton.Name = "ChannelFour_SmallDownButton";
            this.ChannelFour_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelFour_SmallDownButton.TabIndex = 28;
            this.ChannelFour_SmallDownButton.TabStop = false;
            // 
            // ChannelFour_TextBox
            // 
            this.ChannelFour_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelFour_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelFour_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelFour_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.ChannelFour_TextBox.Location = new System.Drawing.Point(422, 6);
            this.ChannelFour_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_TextBox.Name = "ChannelFour_TextBox";
            this.ChannelFour_TextBox.ReadOnly = true;
            this.ChannelFour_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelFour_TextBox.TabIndex = 27;
            this.ChannelFour_TextBox.Text = "100 mV/div";
            // 
            // ChannelThree_StatusBar
            // 
            this.ChannelThree_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_StatusBar.Image")));
            this.ChannelThree_StatusBar.Location = new System.Drawing.Point(293, 25);
            this.ChannelThree_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_StatusBar.Name = "ChannelThree_StatusBar";
            this.ChannelThree_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelThree_StatusBar.TabIndex = 26;
            this.ChannelThree_StatusBar.TabStop = false;
            // 
            // ChannelThree_BigUpButton
            // 
            this.ChannelThree_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_BigUpButton.Image")));
            this.ChannelThree_BigUpButton.Location = new System.Drawing.Point(365, 29);
            this.ChannelThree_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_BigUpButton.Name = "ChannelThree_BigUpButton";
            this.ChannelThree_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_BigUpButton.TabIndex = 25;
            this.ChannelThree_BigUpButton.TabStop = false;
            // 
            // ChannelThree_BigDownButton
            // 
            this.ChannelThree_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_BigDownButton.Image")));
            this.ChannelThree_BigDownButton.Location = new System.Drawing.Point(346, 29);
            this.ChannelThree_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_BigDownButton.Name = "ChannelThree_BigDownButton";
            this.ChannelThree_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_BigDownButton.TabIndex = 24;
            this.ChannelThree_BigDownButton.TabStop = false;
            // 
            // ChannelThree_DefaultButton
            // 
            this.ChannelThree_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_DefaultButton.Image")));
            this.ChannelThree_DefaultButton.Location = new System.Drawing.Point(331, 29);
            this.ChannelThree_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_DefaultButton.Name = "ChannelThree_DefaultButton";
            this.ChannelThree_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelThree_DefaultButton.TabIndex = 23;
            this.ChannelThree_DefaultButton.TabStop = false;
            // 
            // ChannelThree_SmallUpButton
            // 
            this.ChannelThree_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_SmallUpButton.Image")));
            this.ChannelThree_SmallUpButton.Location = new System.Drawing.Point(312, 29);
            this.ChannelThree_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_SmallUpButton.Name = "ChannelThree_SmallUpButton";
            this.ChannelThree_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_SmallUpButton.TabIndex = 22;
            this.ChannelThree_SmallUpButton.TabStop = false;
            // 
            // ChannelThree_SmallDownButton
            // 
            this.ChannelThree_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_SmallDownButton.Image")));
            this.ChannelThree_SmallDownButton.Location = new System.Drawing.Point(293, 29);
            this.ChannelThree_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_SmallDownButton.Name = "ChannelThree_SmallDownButton";
            this.ChannelThree_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelThree_SmallDownButton.TabIndex = 21;
            this.ChannelThree_SmallDownButton.TabStop = false;
            // 
            // ChannelThree_TextBox
            // 
            this.ChannelThree_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelThree_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelThree_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelThree_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(252)))), ((int)(((byte)(148)))));
            this.ChannelThree_TextBox.Location = new System.Drawing.Point(293, 6);
            this.ChannelThree_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_TextBox.Name = "ChannelThree_TextBox";
            this.ChannelThree_TextBox.ReadOnly = true;
            this.ChannelThree_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelThree_TextBox.TabIndex = 20;
            this.ChannelThree_TextBox.Text = "100 mV/div";
            // 
            // ChannelFour_Button
            // 
            this.ChannelFour_Button.Image = ((System.Drawing.Image)(resources.GetObject("ChannelFour_Button.Image")));
            this.ChannelFour_Button.Location = new System.Drawing.Point(390, 6);
            this.ChannelFour_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelFour_Button.Name = "ChannelFour_Button";
            this.ChannelFour_Button.Size = new System.Drawing.Size(29, 41);
            this.ChannelFour_Button.TabIndex = 19;
            this.ChannelFour_Button.TabStop = false;
            // 
            // ChannelThree_Button
            // 
            this.ChannelThree_Button.Image = ((System.Drawing.Image)(resources.GetObject("ChannelThree_Button.Image")));
            this.ChannelThree_Button.Location = new System.Drawing.Point(261, 6);
            this.ChannelThree_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelThree_Button.Name = "ChannelThree_Button";
            this.ChannelThree_Button.Size = new System.Drawing.Size(29, 41);
            this.ChannelThree_Button.TabIndex = 18;
            this.ChannelThree_Button.TabStop = false;
            // 
            // ChannelTwo_StatusBar
            // 
            this.ChannelTwo_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_StatusBar.Image")));
            this.ChannelTwo_StatusBar.Location = new System.Drawing.Point(164, 25);
            this.ChannelTwo_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_StatusBar.Name = "ChannelTwo_StatusBar";
            this.ChannelTwo_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelTwo_StatusBar.TabIndex = 17;
            this.ChannelTwo_StatusBar.TabStop = false;
            // 
            // ChannelTwo_BigUpButton
            // 
            this.ChannelTwo_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_BigUpButton.Image")));
            this.ChannelTwo_BigUpButton.Location = new System.Drawing.Point(236, 29);
            this.ChannelTwo_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_BigUpButton.Name = "ChannelTwo_BigUpButton";
            this.ChannelTwo_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_BigUpButton.TabIndex = 16;
            this.ChannelTwo_BigUpButton.TabStop = false;
            // 
            // ChannelTwo_BigDownButton
            // 
            this.ChannelTwo_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_BigDownButton.Image")));
            this.ChannelTwo_BigDownButton.Location = new System.Drawing.Point(217, 29);
            this.ChannelTwo_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_BigDownButton.Name = "ChannelTwo_BigDownButton";
            this.ChannelTwo_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_BigDownButton.TabIndex = 15;
            this.ChannelTwo_BigDownButton.TabStop = false;
            // 
            // ChannelTwo_DefaultButton
            // 
            this.ChannelTwo_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_DefaultButton.Image")));
            this.ChannelTwo_DefaultButton.Location = new System.Drawing.Point(202, 29);
            this.ChannelTwo_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_DefaultButton.Name = "ChannelTwo_DefaultButton";
            this.ChannelTwo_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelTwo_DefaultButton.TabIndex = 14;
            this.ChannelTwo_DefaultButton.TabStop = false;
            // 
            // ChannelTwo_SmallUpButton
            // 
            this.ChannelTwo_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_SmallUpButton.Image")));
            this.ChannelTwo_SmallUpButton.Location = new System.Drawing.Point(183, 29);
            this.ChannelTwo_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_SmallUpButton.Name = "ChannelTwo_SmallUpButton";
            this.ChannelTwo_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_SmallUpButton.TabIndex = 13;
            this.ChannelTwo_SmallUpButton.TabStop = false;
            // 
            // ChannelTwo_SmallDownButton
            // 
            this.ChannelTwo_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_SmallDownButton.Image")));
            this.ChannelTwo_SmallDownButton.Location = new System.Drawing.Point(164, 29);
            this.ChannelTwo_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_SmallDownButton.Name = "ChannelTwo_SmallDownButton";
            this.ChannelTwo_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelTwo_SmallDownButton.TabIndex = 12;
            this.ChannelTwo_SmallDownButton.TabStop = false;
            // 
            // ChannelTwo_TextBox
            // 
            this.ChannelTwo_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelTwo_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelTwo_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelTwo_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChannelTwo_TextBox.Location = new System.Drawing.Point(164, 6);
            this.ChannelTwo_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_TextBox.Name = "ChannelTwo_TextBox";
            this.ChannelTwo_TextBox.ReadOnly = true;
            this.ChannelTwo_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelTwo_TextBox.TabIndex = 11;
            this.ChannelTwo_TextBox.Text = "100 mV/div";
            // 
            // ChannelOne_StatusBar
            // 
            this.ChannelOne_StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_StatusBar.Image")));
            this.ChannelOne_StatusBar.Location = new System.Drawing.Point(35, 25);
            this.ChannelOne_StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_StatusBar.Name = "ChannelOne_StatusBar";
            this.ChannelOne_StatusBar.Size = new System.Drawing.Size(92, 5);
            this.ChannelOne_StatusBar.TabIndex = 10;
            this.ChannelOne_StatusBar.TabStop = false;
            // 
            // ChannelOne_TextBox
            // 
            this.ChannelOne_TextBox.BackColor = System.Drawing.Color.Black;
            this.ChannelOne_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelOne_TextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelOne_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(132)))));
            this.ChannelOne_TextBox.Location = new System.Drawing.Point(35, 6);
            this.ChannelOne_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_TextBox.Name = "ChannelOne_TextBox";
            this.ChannelOne_TextBox.ReadOnly = true;
            this.ChannelOne_TextBox.Size = new System.Drawing.Size(92, 20);
            this.ChannelOne_TextBox.TabIndex = 9;
            this.ChannelOne_TextBox.Text = "100 mV/div";
            // 
            // ChannelOne_BigUpButton
            // 
            this.ChannelOne_BigUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_BigUpButton.Image")));
            this.ChannelOne_BigUpButton.Location = new System.Drawing.Point(107, 29);
            this.ChannelOne_BigUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_BigUpButton.Name = "ChannelOne_BigUpButton";
            this.ChannelOne_BigUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_BigUpButton.TabIndex = 8;
            this.ChannelOne_BigUpButton.TabStop = false;
            this.ChannelOne_BigUpButton.Click += new System.EventHandler(this.ChannelOne_BigUpButton_Click);
            // 
            // ChannelOne_BigDownButton
            // 
            this.ChannelOne_BigDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_BigDownButton.Image")));
            this.ChannelOne_BigDownButton.Location = new System.Drawing.Point(88, 29);
            this.ChannelOne_BigDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_BigDownButton.Name = "ChannelOne_BigDownButton";
            this.ChannelOne_BigDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_BigDownButton.TabIndex = 7;
            this.ChannelOne_BigDownButton.TabStop = false;
            // 
            // ChannelOne_DefaultButton
            // 
            this.ChannelOne_DefaultButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_DefaultButton.Image")));
            this.ChannelOne_DefaultButton.Location = new System.Drawing.Point(73, 29);
            this.ChannelOne_DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_DefaultButton.Name = "ChannelOne_DefaultButton";
            this.ChannelOne_DefaultButton.Size = new System.Drawing.Size(16, 18);
            this.ChannelOne_DefaultButton.TabIndex = 6;
            this.ChannelOne_DefaultButton.TabStop = false;
            // 
            // ChannelOne_SmallUpButton
            // 
            this.ChannelOne_SmallUpButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_SmallUpButton.Image")));
            this.ChannelOne_SmallUpButton.Location = new System.Drawing.Point(54, 29);
            this.ChannelOne_SmallUpButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_SmallUpButton.Name = "ChannelOne_SmallUpButton";
            this.ChannelOne_SmallUpButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_SmallUpButton.TabIndex = 5;
            this.ChannelOne_SmallUpButton.TabStop = false;
            this.ChannelOne_SmallUpButton.Click += new System.EventHandler(this.ChannelOne_SmallUpButton_Click);
            // 
            // ChannelOne_SmallDownButton
            // 
            this.ChannelOne_SmallDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_SmallDownButton.Image")));
            this.ChannelOne_SmallDownButton.Location = new System.Drawing.Point(35, 29);
            this.ChannelOne_SmallDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_SmallDownButton.Name = "ChannelOne_SmallDownButton";
            this.ChannelOne_SmallDownButton.Size = new System.Drawing.Size(20, 18);
            this.ChannelOne_SmallDownButton.TabIndex = 4;
            this.ChannelOne_SmallDownButton.TabStop = false;
            // 
            // timebase_DelayButton
            // 
            this.timebase_DelayButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_DelayButton.Image")));
            this.timebase_DelayButton.Location = new System.Drawing.Point(526, 74);
            this.timebase_DelayButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_DelayButton.Name = "timebase_DelayButton";
            this.timebase_DelayButton.Size = new System.Drawing.Size(33, 15);
            this.timebase_DelayButton.TabIndex = 3;
            this.timebase_DelayButton.TabStop = false;
            // 
            // timebase_PositionButton
            // 
            this.timebase_PositionButton.Image = ((System.Drawing.Image)(resources.GetObject("timebase_PositionButton.Image")));
            this.timebase_PositionButton.Location = new System.Drawing.Point(526, 58);
            this.timebase_PositionButton.Margin = new System.Windows.Forms.Padding(0);
            this.timebase_PositionButton.Name = "timebase_PositionButton";
            this.timebase_PositionButton.Size = new System.Drawing.Size(33, 16);
            this.timebase_PositionButton.TabIndex = 2;
            this.timebase_PositionButton.TabStop = false;
            // 
            // ChannelTwo_Button
            // 
            this.ChannelTwo_Button.Image = ((System.Drawing.Image)(resources.GetObject("ChannelTwo_Button.Image")));
            this.ChannelTwo_Button.Location = new System.Drawing.Point(132, 6);
            this.ChannelTwo_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelTwo_Button.Name = "ChannelTwo_Button";
            this.ChannelTwo_Button.Size = new System.Drawing.Size(29, 41);
            this.ChannelTwo_Button.TabIndex = 1;
            this.ChannelTwo_Button.TabStop = false;
            // 
            // ChannelOne_Button
            // 
            this.ChannelOne_Button.Image = ((System.Drawing.Image)(resources.GetObject("ChannelOne_Button.Image")));
            this.ChannelOne_Button.Location = new System.Drawing.Point(3, 6);
            this.ChannelOne_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelOne_Button.Name = "ChannelOne_Button";
            this.ChannelOne_Button.Size = new System.Drawing.Size(29, 41);
            this.ChannelOne_Button.TabIndex = 0;
            this.ChannelOne_Button.TabStop = false;
            // 
            // downMenuPanel
            // 
            this.downMenuPanel.BackColor = System.Drawing.Color.Silver;
            this.downMenuPanel.Controls.Add(this.downMenu_EmptyButtons);
            this.downMenuPanel.Controls.Add(this.downMenu_UtilityButton);
            this.downMenuPanel.Controls.Add(this.downMenu_MaskButton);
            this.downMenuPanel.Controls.Add(this.downMenu_DiagramButton);
            this.downMenuPanel.Controls.Add(this.downMenu_HistogramButton);
            this.downMenuPanel.Controls.Add(this.downMenu_RightMouseIcon);
            this.downMenuPanel.Controls.Add(this.downMenu_LeftMouseIcon);
            this.downMenuPanel.Controls.Add(this.downMenu_MathButton);
            this.downMenuPanel.Controls.Add(this.downMenu_DisplayButton);
            this.downMenuPanel.Controls.Add(this.downMenu_MeasureButton);
            this.downMenuPanel.Controls.Add(this.downMenu_ChannelsButton);
            this.downMenuPanel.Controls.Add(this.downMenu_MarkerButton);
            this.downMenuPanel.Controls.Add(this.downMenu_AcquireButton);
            this.downMenuPanel.Controls.Add(this.downMenu_SaveButton);
            this.downMenuPanel.Controls.Add(this.downMenu_TriggerButton);
            this.downMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downMenuPanel.Location = new System.Drawing.Point(0, 625);
            this.downMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.downMenuPanel.Name = "downMenuPanel";
            this.downMenuPanel.Size = new System.Drawing.Size(1040, 55);
            this.downMenuPanel.TabIndex = 12;
            // 
            // downMenu_EmptyButtons
            // 
            this.downMenu_EmptyButtons.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_EmptyButtons.Image")));
            this.downMenu_EmptyButtons.Location = new System.Drawing.Point(314, 25);
            this.downMenu_EmptyButtons.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_EmptyButtons.Name = "downMenu_EmptyButtons";
            this.downMenu_EmptyButtons.Size = new System.Drawing.Size(363, 19);
            this.downMenu_EmptyButtons.TabIndex = 13;
            this.downMenu_EmptyButtons.TabStop = false;
            // 
            // downMenu_UtilityButton
            // 
            this.downMenu_UtilityButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_UtilityButton.Image")));
            this.downMenu_UtilityButton.Location = new System.Drawing.Point(677, 24);
            this.downMenu_UtilityButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_UtilityButton.Name = "downMenu_UtilityButton";
            this.downMenu_UtilityButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_UtilityButton.TabIndex = 13;
            this.downMenu_UtilityButton.TabStop = false;
            this.downMenu_UtilityButton.Click += new System.EventHandler(this.downMenu_UtilityButton_Click);
            // 
            // downMenu_MaskButton
            // 
            this.downMenu_MaskButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_MaskButton.Image")));
            this.downMenu_MaskButton.Location = new System.Drawing.Point(222, 24);
            this.downMenu_MaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_MaskButton.Name = "downMenu_MaskButton";
            this.downMenu_MaskButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_MaskButton.TabIndex = 13;
            this.downMenu_MaskButton.TabStop = false;
            this.downMenu_MaskButton.Click += new System.EventHandler(this.downMenu_MaskButton_Click);
            // 
            // downMenu_DiagramButton
            // 
            this.downMenu_DiagramButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_DiagramButton.Image")));
            this.downMenu_DiagramButton.Location = new System.Drawing.Point(131, 24);
            this.downMenu_DiagramButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_DiagramButton.Name = "downMenu_DiagramButton";
            this.downMenu_DiagramButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_DiagramButton.TabIndex = 13;
            this.downMenu_DiagramButton.TabStop = false;
            this.downMenu_DiagramButton.Click += new System.EventHandler(this.downMenu_DiagramButton_Click);
            // 
            // downMenu_HistogramButton
            // 
            this.downMenu_HistogramButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_HistogramButton.Image")));
            this.downMenu_HistogramButton.Location = new System.Drawing.Point(39, 24);
            this.downMenu_HistogramButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_HistogramButton.Name = "downMenu_HistogramButton";
            this.downMenu_HistogramButton.Size = new System.Drawing.Size(93, 20);
            this.downMenu_HistogramButton.TabIndex = 13;
            this.downMenu_HistogramButton.TabStop = false;
            this.downMenu_HistogramButton.Click += new System.EventHandler(this.downMenu_HistogramButton_Click);
            // 
            // downMenu_RightMouseIcon
            // 
            this.downMenu_RightMouseIcon.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_RightMouseIcon.Image")));
            this.downMenu_RightMouseIcon.Location = new System.Drawing.Point(771, 3);
            this.downMenu_RightMouseIcon.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_RightMouseIcon.Name = "downMenu_RightMouseIcon";
            this.downMenu_RightMouseIcon.Size = new System.Drawing.Size(36, 40);
            this.downMenu_RightMouseIcon.TabIndex = 12;
            this.downMenu_RightMouseIcon.TabStop = false;
            // 
            // downMenu_LeftMouseIcon
            // 
            this.downMenu_LeftMouseIcon.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_LeftMouseIcon.Image")));
            this.downMenu_LeftMouseIcon.Location = new System.Drawing.Point(0, 3);
            this.downMenu_LeftMouseIcon.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_LeftMouseIcon.Name = "downMenu_LeftMouseIcon";
            this.downMenu_LeftMouseIcon.Size = new System.Drawing.Size(36, 40);
            this.downMenu_LeftMouseIcon.TabIndex = 0;
            this.downMenu_LeftMouseIcon.TabStop = false;
            // 
            // downMenu_MathButton
            // 
            this.downMenu_MathButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_MathButton.Image")));
            this.downMenu_MathButton.Location = new System.Drawing.Point(677, 5);
            this.downMenu_MathButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_MathButton.Name = "downMenu_MathButton";
            this.downMenu_MathButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_MathButton.TabIndex = 11;
            this.downMenu_MathButton.TabStop = false;
            this.downMenu_MathButton.Click += new System.EventHandler(this.downMenu_MathButton_Click);
            // 
            // downMenu_DisplayButton
            // 
            this.downMenu_DisplayButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_DisplayButton.Image")));
            this.downMenu_DisplayButton.Location = new System.Drawing.Point(313, 5);
            this.downMenu_DisplayButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_DisplayButton.Name = "downMenu_DisplayButton";
            this.downMenu_DisplayButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_DisplayButton.TabIndex = 7;
            this.downMenu_DisplayButton.TabStop = false;
            this.downMenu_DisplayButton.Click += new System.EventHandler(this.downMenu_DisplayButton_Click);
            // 
            // downMenu_MeasureButton
            // 
            this.downMenu_MeasureButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_MeasureButton.Image")));
            this.downMenu_MeasureButton.Location = new System.Drawing.Point(586, 5);
            this.downMenu_MeasureButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_MeasureButton.Name = "downMenu_MeasureButton";
            this.downMenu_MeasureButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_MeasureButton.TabIndex = 10;
            this.downMenu_MeasureButton.TabStop = false;
            this.downMenu_MeasureButton.Click += new System.EventHandler(this.downMenu_MeasureButton_Click);
            // 
            // downMenu_ChannelsButton
            // 
            this.downMenu_ChannelsButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_ChannelsButton.Image")));
            this.downMenu_ChannelsButton.Location = new System.Drawing.Point(39, 5);
            this.downMenu_ChannelsButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_ChannelsButton.Name = "downMenu_ChannelsButton";
            this.downMenu_ChannelsButton.Size = new System.Drawing.Size(93, 20);
            this.downMenu_ChannelsButton.TabIndex = 4;
            this.downMenu_ChannelsButton.TabStop = false;
            this.downMenu_ChannelsButton.Click += new System.EventHandler(this.downMenu_ChannelsButton_Click);
            // 
            // downMenu_MarkerButton
            // 
            this.downMenu_MarkerButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_MarkerButton.Image")));
            this.downMenu_MarkerButton.Location = new System.Drawing.Point(495, 5);
            this.downMenu_MarkerButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_MarkerButton.Name = "downMenu_MarkerButton";
            this.downMenu_MarkerButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_MarkerButton.TabIndex = 9;
            this.downMenu_MarkerButton.TabStop = false;
            this.downMenu_MarkerButton.Click += new System.EventHandler(this.downMenu_MarkerButton_Click);
            // 
            // downMenu_AcquireButton
            // 
            this.downMenu_AcquireButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_AcquireButton.Image")));
            this.downMenu_AcquireButton.Location = new System.Drawing.Point(131, 5);
            this.downMenu_AcquireButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_AcquireButton.Name = "downMenu_AcquireButton";
            this.downMenu_AcquireButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_AcquireButton.TabIndex = 5;
            this.downMenu_AcquireButton.TabStop = false;
            this.downMenu_AcquireButton.Click += new System.EventHandler(this.downMenu_AcquireButton_Click);
            // 
            // downMenu_SaveButton
            // 
            this.downMenu_SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_SaveButton.Image")));
            this.downMenu_SaveButton.Location = new System.Drawing.Point(404, 5);
            this.downMenu_SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_SaveButton.Name = "downMenu_SaveButton";
            this.downMenu_SaveButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_SaveButton.TabIndex = 8;
            this.downMenu_SaveButton.TabStop = false;
            this.downMenu_SaveButton.Click += new System.EventHandler(this.downMenu_SaveButton_Click);
            // 
            // downMenu_TriggerButton
            // 
            this.downMenu_TriggerButton.Image = ((System.Drawing.Image)(resources.GetObject("downMenu_TriggerButton.Image")));
            this.downMenu_TriggerButton.Location = new System.Drawing.Point(222, 5);
            this.downMenu_TriggerButton.Margin = new System.Windows.Forms.Padding(0);
            this.downMenu_TriggerButton.Name = "downMenu_TriggerButton";
            this.downMenu_TriggerButton.Size = new System.Drawing.Size(92, 20);
            this.downMenu_TriggerButton.TabIndex = 6;
            this.downMenu_TriggerButton.TabStop = false;
            this.downMenu_TriggerButton.Click += new System.EventHandler(this.downMenu_TriggerButton_Click);
            // 
            // rightMainTab
            // 
            this.rightMainTab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rightMainTab.Controls.Add(this.rightTopTab);
            this.rightMainTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightMainTab.Location = new System.Drawing.Point(1040, 24);
            this.rightMainTab.Margin = new System.Windows.Forms.Padding(0);
            this.rightMainTab.Name = "rightMainTab";
            this.rightMainTab.Size = new System.Drawing.Size(230, 680);
            this.rightMainTab.TabIndex = 4;
            this.rightMainTab.Visible = false;
            // 
            // rightTopTab
            // 
            this.rightTopTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.rightTopTab.Controls.Add(this.rightTopTab_CancelButton);
            this.rightTopTab.Location = new System.Drawing.Point(0, 0);
            this.rightTopTab.Margin = new System.Windows.Forms.Padding(0);
            this.rightTopTab.Name = "rightTopTab";
            this.rightTopTab.Size = new System.Drawing.Size(230, 56);
            this.rightTopTab.TabIndex = 1;
            // 
            // rightTopTab_CancelButton
            // 
            this.rightTopTab_CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("rightTopTab_CancelButton.Image")));
            this.rightTopTab_CancelButton.Location = new System.Drawing.Point(15, 6);
            this.rightTopTab_CancelButton.Name = "rightTopTab_CancelButton";
            this.rightTopTab_CancelButton.Size = new System.Drawing.Size(23, 21);
            this.rightTopTab_CancelButton.TabIndex = 0;
            this.rightTopTab_CancelButton.TabStop = false;
            this.rightTopTab_CancelButton.Click += new System.EventHandler(this.rightTopTab_CancelButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.measurementsToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1270, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wfmMemoryToolStripMenuItem,
            this.downloadWfmToolStripMenuItem,
            this.saveWaveformToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.setupsToolStripMenuItem,
            this.openDfltSetupToolStripMenuItem,
            this.printToPrinterToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printerSetupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // wfmMemoryToolStripMenuItem
            // 
            this.wfmMemoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visibleM1ToolStripMenuItem,
            this.visibleM2ToolStripMenuItem,
            this.visibleM3ToolStripMenuItem,
            this.visibleM4ToolStripMenuItem,
            this.visibleAllToolStripMenuItem,
            this.invisibleAllToolStripMenuItem,
            this.clearM1ToolStripMenuItem,
            this.clearM2ToolStripMenuItem,
            this.clearM3ToolStripMenuItem,
            this.clearM4ToolStripMenuItem,
            this.clearAllMemoToolStripMenuItem});
            this.wfmMemoryToolStripMenuItem.Name = "wfmMemoryToolStripMenuItem";
            this.wfmMemoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wfmMemoryToolStripMenuItem.Text = "Waveform Memory";
            // 
            // visibleM1ToolStripMenuItem
            // 
            this.visibleM1ToolStripMenuItem.Name = "visibleM1ToolStripMenuItem";
            this.visibleM1ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.visibleM1ToolStripMenuItem.Text = "Visible M1";
            // 
            // visibleM2ToolStripMenuItem
            // 
            this.visibleM2ToolStripMenuItem.Name = "visibleM2ToolStripMenuItem";
            this.visibleM2ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.visibleM2ToolStripMenuItem.Text = "Visible M2";
            // 
            // visibleM3ToolStripMenuItem
            // 
            this.visibleM3ToolStripMenuItem.Name = "visibleM3ToolStripMenuItem";
            this.visibleM3ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.visibleM3ToolStripMenuItem.Text = "Visible M3";
            // 
            // visibleM4ToolStripMenuItem
            // 
            this.visibleM4ToolStripMenuItem.Name = "visibleM4ToolStripMenuItem";
            this.visibleM4ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.visibleM4ToolStripMenuItem.Text = "Visible M4";
            // 
            // visibleAllToolStripMenuItem
            // 
            this.visibleAllToolStripMenuItem.Name = "visibleAllToolStripMenuItem";
            this.visibleAllToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.visibleAllToolStripMenuItem.Text = "Visible All";
            // 
            // invisibleAllToolStripMenuItem
            // 
            this.invisibleAllToolStripMenuItem.Name = "invisibleAllToolStripMenuItem";
            this.invisibleAllToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.invisibleAllToolStripMenuItem.Text = "Invisible All";
            // 
            // clearM1ToolStripMenuItem
            // 
            this.clearM1ToolStripMenuItem.Name = "clearM1ToolStripMenuItem";
            this.clearM1ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearM1ToolStripMenuItem.Text = "Clear M1";
            // 
            // clearM2ToolStripMenuItem
            // 
            this.clearM2ToolStripMenuItem.Name = "clearM2ToolStripMenuItem";
            this.clearM2ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearM2ToolStripMenuItem.Text = "Clear M2";
            // 
            // clearM3ToolStripMenuItem
            // 
            this.clearM3ToolStripMenuItem.Name = "clearM3ToolStripMenuItem";
            this.clearM3ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearM3ToolStripMenuItem.Text = "Clear M3";
            // 
            // clearM4ToolStripMenuItem
            // 
            this.clearM4ToolStripMenuItem.Name = "clearM4ToolStripMenuItem";
            this.clearM4ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearM4ToolStripMenuItem.Text = "Clear M4";
            // 
            // clearAllMemoToolStripMenuItem
            // 
            this.clearAllMemoToolStripMenuItem.Name = "clearAllMemoToolStripMenuItem";
            this.clearAllMemoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearAllMemoToolStripMenuItem.Text = "Clear All Memo";
            // 
            // downloadWfmToolStripMenuItem
            // 
            this.downloadWfmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toMemoryM1ToolStripMenuItem,
            this.toMemoryM2ToolStripMenuItem,
            this.toMemoryM3ToolStripMenuItem,
            this.toMemoryM4ToolStripMenuItem});
            this.downloadWfmToolStripMenuItem.Name = "downloadWfmToolStripMenuItem";
            this.downloadWfmToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.downloadWfmToolStripMenuItem.Text = "Download Waveform";
            // 
            // toMemoryM1ToolStripMenuItem
            // 
            this.toMemoryM1ToolStripMenuItem.Name = "toMemoryM1ToolStripMenuItem";
            this.toMemoryM1ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.toMemoryM1ToolStripMenuItem.Text = "to Memory M1";
            // 
            // toMemoryM2ToolStripMenuItem
            // 
            this.toMemoryM2ToolStripMenuItem.Name = "toMemoryM2ToolStripMenuItem";
            this.toMemoryM2ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.toMemoryM2ToolStripMenuItem.Text = "to Memory M2";
            // 
            // toMemoryM3ToolStripMenuItem
            // 
            this.toMemoryM3ToolStripMenuItem.Name = "toMemoryM3ToolStripMenuItem";
            this.toMemoryM3ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.toMemoryM3ToolStripMenuItem.Text = "to Memory M3";
            // 
            // toMemoryM4ToolStripMenuItem
            // 
            this.toMemoryM4ToolStripMenuItem.Name = "toMemoryM4ToolStripMenuItem";
            this.toMemoryM4ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.toMemoryM4ToolStripMenuItem.Text = "to Memory M4";
            // 
            // saveWaveformToolStripMenuItem
            // 
            this.saveWaveformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ch1ToolStripMenuItem,
            this.ch2ToolStripMenuItem,
            this.ch3ToolStripMenuItem,
            this.ch4ToolStripMenuItem,
            this.f1ToolStripMenuItem,
            this.f2ToolStripMenuItem,
            this.f3ToolStripMenuItem,
            this.f4ToolStripMenuItem,
            this.m1ToolStripMenuItem,
            this.m2ToolStripMenuItem,
            this.m3ToolStripMenuItem,
            this.m4ToolStripMenuItem});
            this.saveWaveformToolStripMenuItem.Name = "saveWaveformToolStripMenuItem";
            this.saveWaveformToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveWaveformToolStripMenuItem.Text = "Save Waveform";
            // 
            // ch1ToolStripMenuItem
            // 
            this.ch1ToolStripMenuItem.Name = "ch1ToolStripMenuItem";
            this.ch1ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.ch1ToolStripMenuItem.Text = "Ch1";
            // 
            // ch2ToolStripMenuItem
            // 
            this.ch2ToolStripMenuItem.Name = "ch2ToolStripMenuItem";
            this.ch2ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.ch2ToolStripMenuItem.Text = "Ch2";
            // 
            // ch3ToolStripMenuItem
            // 
            this.ch3ToolStripMenuItem.Name = "ch3ToolStripMenuItem";
            this.ch3ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.ch3ToolStripMenuItem.Text = "Ch3";
            // 
            // ch4ToolStripMenuItem
            // 
            this.ch4ToolStripMenuItem.Name = "ch4ToolStripMenuItem";
            this.ch4ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.ch4ToolStripMenuItem.Text = "Ch4";
            // 
            // f1ToolStripMenuItem
            // 
            this.f1ToolStripMenuItem.Name = "f1ToolStripMenuItem";
            this.f1ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.f1ToolStripMenuItem.Text = "F1";
            // 
            // f2ToolStripMenuItem
            // 
            this.f2ToolStripMenuItem.Name = "f2ToolStripMenuItem";
            this.f2ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.f2ToolStripMenuItem.Text = "F2";
            // 
            // f3ToolStripMenuItem
            // 
            this.f3ToolStripMenuItem.Name = "f3ToolStripMenuItem";
            this.f3ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.f3ToolStripMenuItem.Text = "F3";
            // 
            // f4ToolStripMenuItem
            // 
            this.f4ToolStripMenuItem.Name = "f4ToolStripMenuItem";
            this.f4ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.f4ToolStripMenuItem.Text = "F4";
            // 
            // m1ToolStripMenuItem
            // 
            this.m1ToolStripMenuItem.Name = "m1ToolStripMenuItem";
            this.m1ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.m1ToolStripMenuItem.Text = "M1";
            // 
            // m2ToolStripMenuItem
            // 
            this.m2ToolStripMenuItem.Name = "m2ToolStripMenuItem";
            this.m2ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.m2ToolStripMenuItem.Text = "M2";
            // 
            // m3ToolStripMenuItem
            // 
            this.m3ToolStripMenuItem.Name = "m3ToolStripMenuItem";
            this.m3ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.m3ToolStripMenuItem.Text = "M3";
            // 
            // m4ToolStripMenuItem
            // 
            this.m4ToolStripMenuItem.Name = "m4ToolStripMenuItem";
            this.m4ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.m4ToolStripMenuItem.Text = "M4";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.visibleToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // visibleToolStripMenuItem
            // 
            this.visibleToolStripMenuItem.Name = "visibleToolStripMenuItem";
            this.visibleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.visibleToolStripMenuItem.Text = "Visible";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // setupsToolStripMenuItem
            // 
            this.setupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSetupToolStripMenuItem,
            this.openFactorySetupToolStripMenuItem,
            this.openPowerOffSetupToolStripMenuItem,
            this.saveSetupToolStripMenuItem,
            this.saveAsDefaultSetupToolStripMenuItem});
            this.setupsToolStripMenuItem.Name = "setupsToolStripMenuItem";
            this.setupsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.setupsToolStripMenuItem.Text = "Setups";
            // 
            // openSetupToolStripMenuItem
            // 
            this.openSetupToolStripMenuItem.Name = "openSetupToolStripMenuItem";
            this.openSetupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openSetupToolStripMenuItem.Text = "Open Setup...";
            // 
            // openFactorySetupToolStripMenuItem
            // 
            this.openFactorySetupToolStripMenuItem.Name = "openFactorySetupToolStripMenuItem";
            this.openFactorySetupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openFactorySetupToolStripMenuItem.Text = "Open Factory Setup";
            // 
            // openPowerOffSetupToolStripMenuItem
            // 
            this.openPowerOffSetupToolStripMenuItem.Name = "openPowerOffSetupToolStripMenuItem";
            this.openPowerOffSetupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openPowerOffSetupToolStripMenuItem.Text = "Open Power Off Setup";
            // 
            // saveSetupToolStripMenuItem
            // 
            this.saveSetupToolStripMenuItem.Name = "saveSetupToolStripMenuItem";
            this.saveSetupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveSetupToolStripMenuItem.Text = "Save Setup...";
            // 
            // saveAsDefaultSetupToolStripMenuItem
            // 
            this.saveAsDefaultSetupToolStripMenuItem.Name = "saveAsDefaultSetupToolStripMenuItem";
            this.saveAsDefaultSetupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveAsDefaultSetupToolStripMenuItem.Text = "Save as Default Setup";
            // 
            // openDfltSetupToolStripMenuItem
            // 
            this.openDfltSetupToolStripMenuItem.Name = "openDfltSetupToolStripMenuItem";
            this.openDfltSetupToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openDfltSetupToolStripMenuItem.Text = "Open Default Setup";
            // 
            // printToPrinterToolStripMenuItem
            // 
            this.printToPrinterToolStripMenuItem.Name = "printToPrinterToolStripMenuItem";
            this.printToPrinterToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printToPrinterToolStripMenuItem.Text = "Print to Printer";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printToolStripMenuItem.Text = "Print ...";
            // 
            // printerSetupToolStripMenuItem
            // 
            this.printerSetupToolStripMenuItem.Name = "printerSetupToolStripMenuItem";
            this.printerSetupToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printerSetupToolStripMenuItem.Text = "Printer Setup ...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyFullScreenToolStripMenuItem,
            this.copyFullWindowToolStripMenuItem,
            this.copyClientAreaToolStripMenuItem,
            this.copyInvClientAreaToolStripMenuItem,
            this.copyScopeScreenToolStripMenuItem,
            this.copyInvScopeScreenToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // copyFullScreenToolStripMenuItem
            // 
            this.copyFullScreenToolStripMenuItem.Name = "copyFullScreenToolStripMenuItem";
            this.copyFullScreenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyFullScreenToolStripMenuItem.Text = "Copy Full Screen";
            // 
            // copyFullWindowToolStripMenuItem
            // 
            this.copyFullWindowToolStripMenuItem.Name = "copyFullWindowToolStripMenuItem";
            this.copyFullWindowToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyFullWindowToolStripMenuItem.Text = "Copy Full Window";
            // 
            // copyClientAreaToolStripMenuItem
            // 
            this.copyClientAreaToolStripMenuItem.Name = "copyClientAreaToolStripMenuItem";
            this.copyClientAreaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyClientAreaToolStripMenuItem.Text = "Copy Client Area";
            // 
            // copyInvClientAreaToolStripMenuItem
            // 
            this.copyInvClientAreaToolStripMenuItem.Name = "copyInvClientAreaToolStripMenuItem";
            this.copyInvClientAreaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyInvClientAreaToolStripMenuItem.Text = "Copy Inv. Client Area";
            // 
            // copyScopeScreenToolStripMenuItem
            // 
            this.copyScopeScreenToolStripMenuItem.Name = "copyScopeScreenToolStripMenuItem";
            this.copyScopeScreenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyScopeScreenToolStripMenuItem.Text = "Copy Scope Screen";
            // 
            // copyInvScopeScreenToolStripMenuItem
            // 
            this.copyInvScopeScreenToolStripMenuItem.Name = "copyInvScopeScreenToolStripMenuItem";
            this.copyInvScopeScreenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyInvScopeScreenToolStripMenuItem.Text = "Copy Inv. Scope Screen";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem,
            this.permanentControlToolStripMenuItem,
            this.measurementAreaToolStripMenuItem,
            this.leftSideMenuToolStripMenuItem,
            this.rightSideMenuToolStripMenuItem,
            this.bothSideMenuToolStripMenuItem,
            this.noSideMenusToolStripMenuItem,
            this.displayStyleScreenToolStripMenuItem,
            this.displayViewColorToolStripMenuItem,
            this.touchscreenToolStripMenuItem,
            this.fixedPositionToolStripMenuItem,
            this.floatingPositionToolStripMenuItem,
            this.largeDotsEnabledToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            // 
            // permanentControlToolStripMenuItem
            // 
            this.permanentControlToolStripMenuItem.Name = "permanentControlToolStripMenuItem";
            this.permanentControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permanentControlToolStripMenuItem.Text = "Permanent Control";
            // 
            // measurementAreaToolStripMenuItem
            // 
            this.measurementAreaToolStripMenuItem.Name = "measurementAreaToolStripMenuItem";
            this.measurementAreaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.measurementAreaToolStripMenuItem.Text = "Measurement Area";
            // 
            // leftSideMenuToolStripMenuItem
            // 
            this.leftSideMenuToolStripMenuItem.Name = "leftSideMenuToolStripMenuItem";
            this.leftSideMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leftSideMenuToolStripMenuItem.Text = "Left Side Menu";
            // 
            // rightSideMenuToolStripMenuItem
            // 
            this.rightSideMenuToolStripMenuItem.Name = "rightSideMenuToolStripMenuItem";
            this.rightSideMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightSideMenuToolStripMenuItem.Text = "Right Side Menu";
            // 
            // bothSideMenuToolStripMenuItem
            // 
            this.bothSideMenuToolStripMenuItem.Name = "bothSideMenuToolStripMenuItem";
            this.bothSideMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bothSideMenuToolStripMenuItem.Text = "Both Side Menu";
            // 
            // noSideMenusToolStripMenuItem
            // 
            this.noSideMenusToolStripMenuItem.Name = "noSideMenusToolStripMenuItem";
            this.noSideMenusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noSideMenusToolStripMenuItem.Text = "No Side Menus";
            // 
            // displayStyleScreenToolStripMenuItem
            // 
            this.displayStyleScreenToolStripMenuItem.Name = "displayStyleScreenToolStripMenuItem";
            this.displayStyleScreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayStyleScreenToolStripMenuItem.Text = "Display Style/Screen";
            // 
            // displayViewColorToolStripMenuItem
            // 
            this.displayViewColorToolStripMenuItem.Name = "displayViewColorToolStripMenuItem";
            this.displayViewColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayViewColorToolStripMenuItem.Text = "Display View/Color";
            // 
            // touchscreenToolStripMenuItem
            // 
            this.touchscreenToolStripMenuItem.Name = "touchscreenToolStripMenuItem";
            this.touchscreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.touchscreenToolStripMenuItem.Text = "Touchscreen";
            // 
            // fixedPositionToolStripMenuItem
            // 
            this.fixedPositionToolStripMenuItem.Name = "fixedPositionToolStripMenuItem";
            this.fixedPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fixedPositionToolStripMenuItem.Text = "Fixed Position";
            // 
            // floatingPositionToolStripMenuItem
            // 
            this.floatingPositionToolStripMenuItem.Name = "floatingPositionToolStripMenuItem";
            this.floatingPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.floatingPositionToolStripMenuItem.Text = "Floating Position";
            // 
            // largeDotsEnabledToolStripMenuItem
            // 
            this.largeDotsEnabledToolStripMenuItem.Name = "largeDotsEnabledToolStripMenuItem";
            this.largeDotsEnabledToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.largeDotsEnabledToolStripMenuItem.Text = "Large Dots Enabled";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channel1ToolStripMenuItem,
            this.channel2ToolStripMenuItem,
            this.channel3ToolStripMenuItem,
            this.channel4ToolStripMenuItem,
            this.timebaseAcquisitionToolStripMenuItem,
            this.triggerToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // channel1ToolStripMenuItem
            // 
            this.channel1ToolStripMenuItem.Name = "channel1ToolStripMenuItem";
            this.channel1ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.channel1ToolStripMenuItem.Text = "Channel 1";
            // 
            // channel2ToolStripMenuItem
            // 
            this.channel2ToolStripMenuItem.Name = "channel2ToolStripMenuItem";
            this.channel2ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.channel2ToolStripMenuItem.Text = "Channel 2";
            // 
            // channel3ToolStripMenuItem
            // 
            this.channel3ToolStripMenuItem.Name = "channel3ToolStripMenuItem";
            this.channel3ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.channel3ToolStripMenuItem.Text = "Channel 3";
            // 
            // channel4ToolStripMenuItem
            // 
            this.channel4ToolStripMenuItem.Name = "channel4ToolStripMenuItem";
            this.channel4ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.channel4ToolStripMenuItem.Text = "Channel 4";
            // 
            // timebaseAcquisitionToolStripMenuItem
            // 
            this.timebaseAcquisitionToolStripMenuItem.Name = "timebaseAcquisitionToolStripMenuItem";
            this.timebaseAcquisitionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.timebaseAcquisitionToolStripMenuItem.Text = "Timebase/Acquisition";
            // 
            // triggerToolStripMenuItem
            // 
            this.triggerToolStripMenuItem.Name = "triggerToolStripMenuItem";
            this.triggerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.triggerToolStripMenuItem.Text = "Trigger";
            // 
            // measurementsToolStripMenuItem
            // 
            this.measurementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markerToolStripMenuItem,
            this.measureToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.eyeDiagramToolStripMenuItem});
            this.measurementsToolStripMenuItem.Name = "measurementsToolStripMenuItem";
            this.measurementsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.measurementsToolStripMenuItem.Text = "Measurements";
            // 
            // markerToolStripMenuItem
            // 
            this.markerToolStripMenuItem.Name = "markerToolStripMenuItem";
            this.markerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.markerToolStripMenuItem.Text = "Marker";
            // 
            // measureToolStripMenuItem
            // 
            this.measureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterToolStripMenuItem,
            this.definitionToolStripMenuItem,
            this.limitTestToolStripMenuItem});
            this.measureToolStripMenuItem.Name = "measureToolStripMenuItem";
            this.measureToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.measureToolStripMenuItem.Text = "Measure";
            // 
            // parameterToolStripMenuItem
            // 
            this.parameterToolStripMenuItem.Name = "parameterToolStripMenuItem";
            this.parameterToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.parameterToolStripMenuItem.Text = "Parameter";
            // 
            // definitionToolStripMenuItem
            // 
            this.definitionToolStripMenuItem.Name = "definitionToolStripMenuItem";
            this.definitionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.definitionToolStripMenuItem.Text = "Definition";
            // 
            // limitTestToolStripMenuItem
            // 
            this.limitTestToolStripMenuItem.Name = "limitTestToolStripMenuItem";
            this.limitTestToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.limitTestToolStripMenuItem.Text = "Limit Test";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramSetupToolStripMenuItem,
            this.windowScaleToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // histogramSetupToolStripMenuItem
            // 
            this.histogramSetupToolStripMenuItem.Name = "histogramSetupToolStripMenuItem";
            this.histogramSetupToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.histogramSetupToolStripMenuItem.Text = "Setup";
            // 
            // windowScaleToolStripMenuItem
            // 
            this.windowScaleToolStripMenuItem.Name = "windowScaleToolStripMenuItem";
            this.windowScaleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.windowScaleToolStripMenuItem.Text = "Window/Scale";
            // 
            // eyeDiagramToolStripMenuItem
            // 
            this.eyeDiagramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterEyeToolStripMenuItem,
            this.definitionEyeToolStripMenuItem});
            this.eyeDiagramToolStripMenuItem.Name = "eyeDiagramToolStripMenuItem";
            this.eyeDiagramToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.eyeDiagramToolStripMenuItem.Text = "Eye Diagram";
            // 
            // parameterEyeToolStripMenuItem
            // 
            this.parameterEyeToolStripMenuItem.Name = "parameterEyeToolStripMenuItem";
            this.parameterEyeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.parameterEyeToolStripMenuItem.Text = "Parameter";
            // 
            // definitionEyeToolStripMenuItem
            // 
            this.definitionEyeToolStripMenuItem.Name = "definitionEyeToolStripMenuItem";
            this.definitionEyeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.definitionEyeToolStripMenuItem.Text = "Definition";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathematicsToolStripMenuItem,
            this.maskTestToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // mathematicsToolStripMenuItem
            // 
            this.mathematicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem,
            this.scalingToolStripMenuItem});
            this.mathematicsToolStripMenuItem.Name = "mathematicsToolStripMenuItem";
            this.mathematicsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.mathematicsToolStripMenuItem.Text = "Mathematics";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // scalingToolStripMenuItem
            // 
            this.scalingToolStripMenuItem.Name = "scalingToolStripMenuItem";
            this.scalingToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.scalingToolStripMenuItem.Text = "Scaling";
            // 
            // maskTestToolStripMenuItem
            // 
            this.maskTestToolStripMenuItem.Name = "maskTestToolStripMenuItem";
            this.maskTestToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.maskTestToolStripMenuItem.Text = "Mask Test";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeInstrumentToolStripMenuItem,
            this.commonLANSettingsToolStripMenuItem,
            this.scanningLANSettingsToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // changeInstrumentToolStripMenuItem
            // 
            this.changeInstrumentToolStripMenuItem.Name = "changeInstrumentToolStripMenuItem";
            this.changeInstrumentToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.changeInstrumentToolStripMenuItem.Text = "Change Instrument";
            // 
            // commonLANSettingsToolStripMenuItem
            // 
            this.commonLANSettingsToolStripMenuItem.Name = "commonLANSettingsToolStripMenuItem";
            this.commonLANSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.commonLANSettingsToolStripMenuItem.Text = "Common LAN Settings";
            // 
            // scanningLANSettingsToolStripMenuItem
            // 
            this.scanningLANSettingsToolStripMenuItem.Name = "scanningLANSettingsToolStripMenuItem";
            this.scanningLANSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.scanningLANSettingsToolStripMenuItem.Text = "Scanning LAN Instruments...";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibrateToolStripMenuItem,
            this.demoToolStripMenuItem,
            this.adjustmentToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // calibrateToolStripMenuItem
            // 
            this.calibrateToolStripMenuItem.Name = "calibrateToolStripMenuItem";
            this.calibrateToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.calibrateToolStripMenuItem.Text = "Calibrate";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.demoToolStripMenuItem.Text = "Demo";
            // 
            // adjustmentToolStripMenuItem
            // 
            this.adjustmentToolStripMenuItem.Name = "adjustmentToolStripMenuItem";
            this.adjustmentToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.adjustmentToolStripMenuItem.Text = "Adjustment";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.picoSample4HelpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.instrumentInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // picoSample4HelpToolStripMenuItem
            // 
            this.picoSample4HelpToolStripMenuItem.Name = "picoSample4HelpToolStripMenuItem";
            this.picoSample4HelpToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.picoSample4HelpToolStripMenuItem.Text = "PicoSample 4 Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // instrumentInfoToolStripMenuItem
            // 
            this.instrumentInfoToolStripMenuItem.Name = "instrumentInfoToolStripMenuItem";
            this.instrumentInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.instrumentInfoToolStripMenuItem.Text = "Instrument Info...";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 704);
            this.Controls.Add(this.rightMainTab);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.leftMainTab);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   PicoSample 4   PicoScope 9404L-05   Sampler Extended Oscilloscope    5 GHz   1" +
    "2-bit ADC   500 MS/s RT   1 TS/s ET";
            this.leftMainTab.ResumeLayout(false);
            this.leftTopTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftTopTab_CancelButton)).EndInit();
            this.mainTab.ResumeLayout(false);
            this.screenPanel.ResumeLayout(false);
            this.screenPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topControlsPanel.ResumeLayout(false);
            this.statusArea_DisplayPanel.ResumeLayout(false);
            this.statusArea_DisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_DisplayFrame)).EndInit();
            this.statusArea_TriggerPanel.ResumeLayout(false);
            this.statusArea_TriggerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_TriggerFrame)).EndInit();
            this.statusArea_AcquirePanel.ResumeLayout(false);
            this.statusArea_AcquirePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_AcquireFrame)).EndInit();
            this.statusArea_ChannelFourPanel.ResumeLayout(false);
            this.statusArea_ChannelFourPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelFourFrame)).EndInit();
            this.statusArea_ChannelThreePanel.ResumeLayout(false);
            this.statusArea_ChannelThreePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelThreeFrame)).EndInit();
            this.statusArea_ChannelTwoPanel.ResumeLayout(false);
            this.statusArea_ChannelTwoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelTwoFrame)).EndInit();
            this.statusArea_ChannelOnePanel.ResumeLayout(false);
            this.statusArea_ChannelOnePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusArea_ChannelOneFrame)).EndInit();
            this.topMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_ClearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_RunButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_SingleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_AutoscaleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_ForwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_CopyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMenu_HelpButton)).EndInit();
            this.measurementsPanel.ResumeLayout(false);
            this.measurementsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_MidButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_MaxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_AutoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementArea_ScalesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementAreaScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPanel)).EndInit();
            this.permanentControlsPanel.ResumeLayout(false);
            this.permanentControlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_ZeroButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerLevel_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerMode_TriggeredButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerMode_FreerunButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSlope_Bislope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSlope_Negative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSlope_Positive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerSource_ChannelOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_BigRightButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_BigLeftButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_SmallRightButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_SmallLeftButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_BigRightButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_BigLeftButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_SmallRightButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PosDelay_SmallLeftButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_OffsetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PositionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_OffsetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PositionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_OffsetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PositionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_OffsetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PositionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_PosOfs_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_PosOfs_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_PosOfs_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_PosOfs_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelFour_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThree_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_BigUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_BigDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_DefaultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_SmallUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_SmallDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_DelayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timebase_PositionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelTwo_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelOne_Button)).EndInit();
            this.downMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_EmptyButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_UtilityButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MaskButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_DiagramButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_HistogramButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_RightMouseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_LeftMouseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MathButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_DisplayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MeasureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_ChannelsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_MarkerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_AcquireButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_SaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downMenu_TriggerButton)).EndInit();
            this.rightMainTab.ResumeLayout(false);
            this.rightTopTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightTopTab_CancelButton)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //  Menu Strip
        private System.Windows.Forms.MenuStrip menuStrip;                                       //  Menu Strip

        //  Menu Item - File
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;                   //  Menu Item - File
        private System.Windows.Forms.ToolStripMenuItem wfmMemoryToolStripMenuItem;              //  Menu Item - File - Waveform Memory
        private System.Windows.Forms.ToolStripMenuItem visibleM1ToolStripMenuItem;              //  Menu Item - File - Waveform Memomory - Visible M1
        private System.Windows.Forms.ToolStripMenuItem visibleM2ToolStripMenuItem;              //  Menu Item - File - Waveform Memomory - Visible M2
        private System.Windows.Forms.ToolStripMenuItem visibleM3ToolStripMenuItem;              //  Menu Item - File - Waveform Memomory - Visible M3
        private System.Windows.Forms.ToolStripMenuItem visibleM4ToolStripMenuItem;              //  Menu Item - File - Waveform Memomory - Visible M4
        private System.Windows.Forms.ToolStripMenuItem visibleAllToolStripMenuItem;             //  Menu Item - File - Waveform Memomory - Visible All
        private System.Windows.Forms.ToolStripMenuItem invisibleAllToolStripMenuItem;           //  Menu Item - File - Waveform Memomory - Invisible All
        private System.Windows.Forms.ToolStripMenuItem clearM1ToolStripMenuItem;                //  Menu Item - File - Waveform Memomory - Clear M1
        private System.Windows.Forms.ToolStripMenuItem clearM2ToolStripMenuItem;                //  Menu Item - File - Waveform Memomory - Clear M2
        private System.Windows.Forms.ToolStripMenuItem clearM3ToolStripMenuItem;                //  Menu Item - File - Waveform Memomory - Clear M3
        private System.Windows.Forms.ToolStripMenuItem clearM4ToolStripMenuItem;                //  Menu Item - File - Waveform Memomory - Clear M4
        private System.Windows.Forms.ToolStripMenuItem clearAllMemoToolStripMenuItem;           //  Menu Item - File - Waveform Memomory - Clear All Memo
        private System.Windows.Forms.ToolStripMenuItem downloadWfmToolStripMenuItem;            //  Menu Item - File - Download Waveform
        private System.Windows.Forms.ToolStripMenuItem toMemoryM1ToolStripMenuItem;             //  Menu Item - File - Download Waveform - to Memory M1
        private System.Windows.Forms.ToolStripMenuItem toMemoryM2ToolStripMenuItem;             //  Menu Item - File - Download Waveform - to Memory M2
        private System.Windows.Forms.ToolStripMenuItem toMemoryM3ToolStripMenuItem;             //  Menu Item - File - Download Waveform - to Memory M3
        private System.Windows.Forms.ToolStripMenuItem toMemoryM4ToolStripMenuItem;             //  Menu Item - File - Download Waveform - to Memory M4
        private System.Windows.Forms.ToolStripMenuItem saveWaveformToolStripMenuItem;           //  Menu Item - File - Save Waveform
        private System.Windows.Forms.ToolStripMenuItem ch1ToolStripMenuItem;                    //  Menu Item - File - Save Waveform - Ch1
        private System.Windows.Forms.ToolStripMenuItem ch2ToolStripMenuItem;                    //  Menu Item - File - Save Waveform - Ch2
        private System.Windows.Forms.ToolStripMenuItem ch3ToolStripMenuItem;                    //  Menu Item - File - Save Waveform - Ch3
        private System.Windows.Forms.ToolStripMenuItem ch4ToolStripMenuItem;                    //  Menu Item - File - Save Waveform - Ch4
        private System.Windows.Forms.ToolStripMenuItem f1ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - F1
        private System.Windows.Forms.ToolStripMenuItem f2ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - F2
        private System.Windows.Forms.ToolStripMenuItem f3ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - F3
        private System.Windows.Forms.ToolStripMenuItem f4ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - F4
        private System.Windows.Forms.ToolStripMenuItem m1ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - M1
        private System.Windows.Forms.ToolStripMenuItem m2ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - M2
        private System.Windows.Forms.ToolStripMenuItem m3ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - M3
        private System.Windows.Forms.ToolStripMenuItem m4ToolStripMenuItem;                     //  Menu Item - File - Save Waveform - M4
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;               //  Menu Item - File - Database
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;               //  Menu Item - File - Database - Download
        private System.Windows.Forms.ToolStripMenuItem visibleToolStripMenuItem;                //  Menu Item - File - Database - Visible
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;                  //  Menu Item - File - Database - Clear
        private System.Windows.Forms.ToolStripMenuItem setupsToolStripMenuItem;                 //  Menu Item - File - Setups
        private System.Windows.Forms.ToolStripMenuItem openSetupToolStripMenuItem;              //  Menu Item - File - Setups - Open Setup
        private System.Windows.Forms.ToolStripMenuItem openFactorySetupToolStripMenuItem;       //  Menu Item - File - Setups - Open Factory Setup
        private System.Windows.Forms.ToolStripMenuItem openPowerOffSetupToolStripMenuItem;      //  Menu Item - File - Setups - Open Power Off
        private System.Windows.Forms.ToolStripMenuItem saveSetupToolStripMenuItem;              //  Menu Item - File - Setups - Save Setup...
        private System.Windows.Forms.ToolStripMenuItem saveAsDefaultSetupToolStripMenuItem;     //  Menu Item - File - Setups - Save as Default Setup
        private System.Windows.Forms.ToolStripMenuItem openDfltSetupToolStripMenuItem;          //  Menu Item - FIle - Open Default Setup
        private System.Windows.Forms.ToolStripMenuItem printToPrinterToolStripMenuItem;         //  Menu Item - File - Print to Printer
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;                  //  Menu Item - File - Print
        private System.Windows.Forms.ToolStripMenuItem printerSetupToolStripMenuItem;           //  Menu Item - File - Printer Setup
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;                   //  Menu Item - File - Exit

        //  Menu Item - Edit
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;                   //  Menu Item - Edit
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;                   //  Menu Item - Edit - Copy
        private System.Windows.Forms.ToolStripMenuItem copyFullScreenToolStripMenuItem;         //  Menu Item - Edit - Copy Full Screen
        private System.Windows.Forms.ToolStripMenuItem copyFullWindowToolStripMenuItem;         //  Menu Item - Edit - Copy Full Window
        private System.Windows.Forms.ToolStripMenuItem copyClientAreaToolStripMenuItem;         //  Menu Item - Edit - Copy Client Area
        private System.Windows.Forms.ToolStripMenuItem copyInvClientAreaToolStripMenuItem;      //  Menu Item - Edit - Copy Inv. Client Area
        private System.Windows.Forms.ToolStripMenuItem copyScopeScreenToolStripMenuItem;        //  Menu Item - Edit - Copy Scope Screen
        private System.Windows.Forms.ToolStripMenuItem copyInvScopeScreenToolStripMenuItem;     //  Menu Item - Edit - Copy Inv. Scope Screen

        //  Menu Item - View
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;                   //  Menu Item - View
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;                //  Menu Item - View - Toolbar
        private System.Windows.Forms.ToolStripMenuItem permanentControlToolStripMenuItem;       //  Menu Item - View - Permanent Control
        private System.Windows.Forms.ToolStripMenuItem measurementAreaToolStripMenuItem;        //  Menu Item - View - Measurement Area
        private System.Windows.Forms.ToolStripMenuItem leftSideMenuToolStripMenuItem;           //  Menu Item - View - Left Side Menu
        private System.Windows.Forms.ToolStripMenuItem rightSideMenuToolStripMenuItem;          //  Menu Item - View - Right Side Menu
        private System.Windows.Forms.ToolStripMenuItem bothSideMenuToolStripMenuItem;           //  Menu Item - View - Both Side Menu
        private System.Windows.Forms.ToolStripMenuItem noSideMenusToolStripMenuItem;            //  Menu Item - View - No Side Menus
        private System.Windows.Forms.ToolStripMenuItem displayStyleScreenToolStripMenuItem;     //  Menu Item - View - Display Style/Screen
        private System.Windows.Forms.ToolStripMenuItem displayViewColorToolStripMenuItem;       //  Menu Item - View - Display View/Color
        private System.Windows.Forms.ToolStripMenuItem touchscreenToolStripMenuItem;            //  Menu Item - View - Touchscreen
        private System.Windows.Forms.ToolStripMenuItem fixedPositionToolStripMenuItem;          //  Menu Item - View - Fixed Position
        private System.Windows.Forms.ToolStripMenuItem floatingPositionToolStripMenuItem;       //  Menu Item - View - Floating Position
        private System.Windows.Forms.ToolStripMenuItem largeDotsEnabledToolStripMenuItem;       //  Menu Item - View - Large Dots Enabled

        //  Menu Item - Setup
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;                  //  Menu Item - Setup
        private System.Windows.Forms.ToolStripMenuItem channel1ToolStripMenuItem;               //  Menu Item - Setup - Channel 1
        private System.Windows.Forms.ToolStripMenuItem channel2ToolStripMenuItem;               //  Menu Item - Setup - Channel 2
        private System.Windows.Forms.ToolStripMenuItem channel3ToolStripMenuItem;               //  Menu Item - Setup - Channel 3
        private System.Windows.Forms.ToolStripMenuItem channel4ToolStripMenuItem;               //  Menu Item - Setup - Channel 4
        private System.Windows.Forms.ToolStripMenuItem timebaseAcquisitionToolStripMenuItem;    //  Menu Item - Setup - Timebase/Acquisition
        private System.Windows.Forms.ToolStripMenuItem triggerToolStripMenuItem;                //  Menu Item - Setup - Trigger

        //  Menu Item - Measurements
        private System.Windows.Forms.ToolStripMenuItem measurementsToolStripMenuItem;           //  Menu Item - Measurements
        private System.Windows.Forms.ToolStripMenuItem markerToolStripMenuItem;                 //  Menu Item - Measurements - Marker
        private System.Windows.Forms.ToolStripMenuItem measureToolStripMenuItem;                //  Menu Item - Measurements - Measure
        private System.Windows.Forms.ToolStripMenuItem parameterToolStripMenuItem;              //  Menu Item - Measurements - Measure - Parameter
        private System.Windows.Forms.ToolStripMenuItem definitionToolStripMenuItem;             //  Menu Item - Measurements - Measure - Definition
        private System.Windows.Forms.ToolStripMenuItem limitTestToolStripMenuItem;              //  Menu Item - Measurements - Measure - Limit Test
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;              //  Menu Item - Measurements - Histogram
        private System.Windows.Forms.ToolStripMenuItem histogramSetupToolStripMenuItem;         //  Menu Item - Measurements - Histogram - Setup
        private System.Windows.Forms.ToolStripMenuItem windowScaleToolStripMenuItem;            //  Menu Item - Measurements - Histogram - windowScale
        private System.Windows.Forms.ToolStripMenuItem eyeDiagramToolStripMenuItem;             //  Menu Item - Measurements - Eye Diagram
        private System.Windows.Forms.ToolStripMenuItem parameterEyeToolStripMenuItem;           //  Menu Item - Measurements - Eye Diagram - Parameter
        private System.Windows.Forms.ToolStripMenuItem definitionEyeToolStripMenuItem;          //  Menu Item - Measurements - Eye Diagram - Definition

        //  Menu Item - Analysis
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;               //  Menu Item - Analysis
        private System.Windows.Forms.ToolStripMenuItem mathematicsToolStripMenuItem;            //  Menu Item - Analysis - Mathematics
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;               //  Menu Item - Analysis - Function
        private System.Windows.Forms.ToolStripMenuItem scalingToolStripMenuItem;                //  Menu Item - Analysis - Scaling
        private System.Windows.Forms.ToolStripMenuItem maskTestToolStripMenuItem;               //  Menu Item - Analysis - Mask Test

        //  Menu Item - System
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;                 //  Menu Item - System
        private System.Windows.Forms.ToolStripMenuItem changeInstrumentToolStripMenuItem;       //  Menu Item - System - Change Instrument
        private System.Windows.Forms.ToolStripMenuItem commonLANSettingsToolStripMenuItem;      //  Menu Item - System - Common LAN Settings
        private System.Windows.Forms.ToolStripMenuItem scanningLANSettingsToolStripMenuItem;    //  Menu Item - System - Scanning LAN Settings

        //  Menu Item - Utylity
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;                //  Menu Item - Utility
        private System.Windows.Forms.ToolStripMenuItem calibrateToolStripMenuItem;              //  Menu Item - Utility - Calibrate
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;                   //  Menu Item - Utility - Demo
        private System.Windows.Forms.ToolStripMenuItem adjustmentToolStripMenuItem;             //  Menu Item - Utility - Adjustment
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;               //  Menu Item - Utility - Language
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;                //  Menu Item - Utility - Language - English

        //  Menu Item - Help
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;                   //  Menu Item - Help
        private System.Windows.Forms.ToolStripMenuItem picoSample4HelpToolStripMenuItem;        //  Menu Item - Help - PicoSample 4 Help
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;                  //  Menu Item - Help - About...
        private System.Windows.Forms.ToolStripMenuItem instrumentInfoToolStripMenuItem;         //  Menu Item - Help - Instrument Info...

        //  Tabs
        private System.Windows.Forms.Panel mainTab;                                             //  Main Tab
        private System.Windows.Forms.Panel leftMainTab;                                         //  Left Main Tab

        //  Left Top Tab
        private System.Windows.Forms.Panel leftTopTab;                                          //  Left Top Tab
        private System.Windows.Forms.PictureBox leftTopTab_CancelButton;                        //  Left Top Tab Cancel Button

        //  Right Main Tab
        private System.Windows.Forms.Panel rightMainTab;                                        //  Right Main Tab

        //  Right Top Tab
        private System.Windows.Forms.Panel rightTopTab;                                         //  Right Top Tab
        private System.Windows.Forms.PictureBox rightTopTab_CancelButton;                       //  Right Top Tab Cancel Button

        //  Top Menu Panel
        private System.Windows.Forms.Panel topMenuPanel;                                        //  Top Menu Panel

        //  Top Menu Buttons
        private System.Windows.Forms.PictureBox topMenu_HelpButton;                             //  Help Button
        private System.Windows.Forms.PictureBox topMenu_CopyButton;                             //  Copy Button
        private System.Windows.Forms.PictureBox topMenu_BackButton;                             //  Back Button
        private System.Windows.Forms.PictureBox topMenu_ForwardButton;                          //  Forward Button
        private System.Windows.Forms.PictureBox topMenu_DefaultButton;                          //  Default Button
        private System.Windows.Forms.PictureBox topMenu_AutoscaleButton;                        //  Autoscale Button
        private System.Windows.Forms.PictureBox topMenu_SingleButton;                           //  Single Button
        private System.Windows.Forms.PictureBox topMenu_StopButton;                             //  Stop Button
        private System.Windows.Forms.PictureBox topMenu_RunButton;                              //  Run Button
        private System.Windows.Forms.PictureBox topMenu_ClearButton;                            //  Clear Button

        //  Top Controls Panel
        private System.Windows.Forms.Panel topControlsPanel;                                    //  Top Controls Panel

        //  Status Area Channel Panels
        private System.Windows.Forms.Panel statusArea_ChannelOnePanel;                          //  Status Area Channel One Panel
        private System.Windows.Forms.Panel statusArea_ChannelTwoPanel;                          //  Status Area Channel Two Panel
        private System.Windows.Forms.Panel statusArea_ChannelThreePanel;                        //  Status Area Channel Three Panel
        private System.Windows.Forms.Panel statusArea_ChannelFourPanel;                         //  Status Area Channel Four Panel

        //  Status Area Channel One
        private System.Windows.Forms.PictureBox statusArea_ChannelOneFrame;                     //  Status Area Channel One Frame
        private System.Windows.Forms.Label statusArea_ChannelOne_Scale;                         //  Status Area Channel One Scale
        private System.Windows.Forms.Label statusArea_ChannelOne_Offset;                        //  Status Area Channel One Offset

        //  Status Area Channel Two
        private System.Windows.Forms.PictureBox statusArea_ChannelTwoFrame;                     //  Status Area Channel Two Frame
        private System.Windows.Forms.Label statusArea_ChannelTwo_Scale;                         //  Status Area Channel Two Scale
        private System.Windows.Forms.Label statusArea_ChannelTwo_Offset;                        //  Status Area Channel Two Offset

        //  Status Area Channel Three
        private System.Windows.Forms.PictureBox statusArea_ChannelThreeFrame;                   //  Status Area Channel Three Frame
        private System.Windows.Forms.Label statusArea_ChannelThree_Scale;                       //  Status Area Channel Three Scale
        private System.Windows.Forms.Label statusArea_ChannelThree_Offset;                      //  Status Area Channel Three Offset

        //  Status Area Channel Four
        private System.Windows.Forms.PictureBox statusArea_ChannelFourFrame;                    //  Status Area Channel Four Frame
        private System.Windows.Forms.Label statusArea_ChannelFour_Scale;                        //  Status Area Channel Four Scale
        private System.Windows.Forms.Label statusArea_ChannelFour_Offset;                       //  Status Area Channel Four Offset

        //  Status Area Acquire
        private System.Windows.Forms.Panel statusArea_AcquirePanel;                             //  Status Area Acquire Panel
        private System.Windows.Forms.PictureBox statusArea_AcquireFrame;                        //  Status Area Acquire Frame
        private System.Windows.Forms.Label statusArea_Acquire_KS;                               //  Status Area Acquire KS
        private System.Windows.Forms.Label statusArea_Acquire_Mode;                             //  Status Area Acquire Mode
        private System.Windows.Forms.Label statusArea_Acquire_Scale;                            //  Status Area Acquire Scale
        private System.Windows.Forms.Label statusArea_Acquire_Waveforms;                        //  Status Area Acquire Waveforms
        private System.Windows.Forms.Label statusArea_Acquire_SampleRate;                       //  Status Area Acquire Sample Rate
        private System.Windows.Forms.Label statusArea_Acquire_SamplingMode;                     //  Status Area Acuire Sampling Mode

        //  Status Area Trigger
        private System.Windows.Forms.Panel statusArea_TriggerPanel;                             //  Status Area Trigger Panel
        private System.Windows.Forms.PictureBox statusArea_TriggerFrame;                        //  Status Area Trigger Frame
        private System.Windows.Forms.Label statusArea_Trigger_Source;                           //  Status Area Trigger Source
        private System.Windows.Forms.Label statusArea_Trigger_Mode;                             //  Status Area Trigger Mode
        private System.Windows.Forms.Label statusArea_Trigger_Frequency;                        //  Status Area Trigger Frequency
        private System.Windows.Forms.Label statusArea_Trigger_Style;                            //  Status Area Trigger Style
        private System.Windows.Forms.Label statusArea_Trigger_Sensitivity;                      //  Status Area Trigger Sensitivity

        //  Status Area Display
        private System.Windows.Forms.Panel statusArea_DisplayPanel;                             //  Status Area Display Panel
        private System.Windows.Forms.PictureBox statusArea_DisplayFrame;                        //  Status Area Display Frame
        private System.Windows.Forms.Label statusArea_Display_Style;                            //  Status Area Display Style
        private System.Windows.Forms.Label statusArea_Display_PersistenceTime;                  //  Status Area Display Persistence Time

        //  Screen Panel
        private System.Windows.Forms.Panel screenPanel;                                         //  Screen Panel

        //  Measurements Panel
        private System.Windows.Forms.Panel measurementsPanel;                                   //  Measurements Panel

        //  Measurement Area Scale
        private System.Windows.Forms.PictureBox measurementAreaScale;                           //  Measurement Area Scale

        //  Measurement Area Buttons
        private System.Windows.Forms.PictureBox measurementArea_MinButton;                      //  Measurement Area Min Button
        private System.Windows.Forms.PictureBox measurementArea_MidButton;                      //  Measurement Area Mid Button
        private System.Windows.Forms.PictureBox measurementArea_MaxButton;                      //  Measurement Area Max Button
        private System.Windows.Forms.PictureBox measurementArea_AutoButton;                     //  Measurement Area Auto Button
        private System.Windows.Forms.PictureBox measurementArea_ScalesButton;                   //  Measurement Area Scales Button

        //  Measurement Area Channels
        private System.Windows.Forms.Label measurementArea_ChannelOne;                          //  Measurement Area Channel One
        private System.Windows.Forms.Label measurementArea_ChannelTwo;                          //  Measurement Area Channel Two
        private System.Windows.Forms.Label measurementArea_ChannelThree;                        //  Measurement Area Channel Three
        private System.Windows.Forms.Label measurementArea_ChannelFour;                         //  Measurement Area Channel Four

        //  Measurement Area Vertical Scale
        private System.Windows.Forms.Label measurementArea_VerticalScale;                       //  Measurement Area Vertical Scale
        private System.Windows.Forms.Label measurementArea_VerticalScale_1ch;                   //  Measurement Area Vertical Scale 1 channel
        private System.Windows.Forms.Label measurementArea_VerticalScale_2ch;                   //  Measurement Area Vertical Scale 2 channel
        private System.Windows.Forms.Label measurementArea_VerticalScale_3ch;                   //  Measurement Area Vertical Scale 3 channel
        private System.Windows.Forms.Label measurementArea_VerticalScale_4ch;                   //  Measurement Area Vertical Scale 4 channel

        //  Measurement Area Offset Position
        private System.Windows.Forms.Label measurementArea_OffsetPosition;                      //  Measurement Area Offset Position
        private System.Windows.Forms.Label measurementArea_OffsetPosition_1ch;                  //  Measurement Area Offset Position 1 channel
        private System.Windows.Forms.Label measurementArea_OffsetPosition_2ch;                  //  Measurement Area Offset Position 2 channel
        private System.Windows.Forms.Label measurementArea_OffsetPosition_3ch;                  //  Measurement Area Offset Position 3 channel
        private System.Windows.Forms.Label measurementArea_OffsetPosition_4ch;                  //  Measurement Area Offset Position 4 channel
        
        //  Measurement Area Horizontal Scale
        private System.Windows.Forms.Label measurementArea_HorizontalScale;                     //  Measurement Area Horizontal Scale
        private System.Windows.Forms.Label measurementArea_HorizontalScale_1ch;                 //  Measurement Area Horizontal Scale 1 channel
        private System.Windows.Forms.Label measurementArea_HorizontalScale_2ch;                 //  Measurement Area Horizontal Scale 2 channel
        private System.Windows.Forms.Label measurementArea_HorizontalScale_3ch;                 //  Measurement Area Horizontal Scale 3 channel
        private System.Windows.Forms.Label measurementArea_HorizontalScale_4ch;                 //  Measurement Area Horizontal Scale 4 channel
        
        //  Measurement Area Delay Position
        private System.Windows.Forms.Label measurementArea_DelayPosition;                       //  Measurement Area Delay Position
        private System.Windows.Forms.Label measurementArea_DelayPosition_1ch;                   //  Measurement Area Delay Position 1 channel
        private System.Windows.Forms.Label measurementArea_DelayPosition_2ch;                   //  Measurement Area Delay Position 2 channel
        private System.Windows.Forms.Label measurementArea_DelayPosition_3ch;                   //  Measurement Area Delay Position 3 channel
        private System.Windows.Forms.Label measurementArea_DelayPosition_4ch;                   //  Measurement Area Delay Position 4 channel
        
        //  Icon Panel
        private System.Windows.Forms.PictureBox iconPanel;                                      //  Icon Panel

        //  Permament Controls Panel
        private System.Windows.Forms.Panel permanentControlsPanel;                              //  Permanent Controls Panel

        //  Channel One
        private System.Windows.Forms.TextBox ChannelOne_TextBox;                                //  Channel One TextBox
        private System.Windows.Forms.PictureBox ChannelOne_Button;                              //  Channel One Button
        private System.Windows.Forms.PictureBox ChannelOne_SmallDownButton;                     //  Channel One Small Down Button
        private System.Windows.Forms.PictureBox ChannelOne_SmallUpButton;                       //  Channel One Small Up Button
        private System.Windows.Forms.PictureBox ChannelOne_DefaultButton;                       //  Channel One Default Button
        private System.Windows.Forms.PictureBox ChannelOne_BigDownButton;                       //  Channel One Big Down Button
        private System.Windows.Forms.PictureBox ChannelOne_BigUpButton;                         //  Channel One Big Up Button
        private System.Windows.Forms.PictureBox ChannelOne_StatusBar;                           //  Channel One Status Bar

        //  Channel One Position Offset
        private System.Windows.Forms.TextBox ChannelOne_PosOfs_TextBox;                         //  Channel One Position Offset TextBox
        private System.Windows.Forms.PictureBox ChannelOne_PositionButton;                      //  Channel One Position Button
        private System.Windows.Forms.PictureBox ChannelOne_OffsetButton;                        //  Channel One Offset Button
        private System.Windows.Forms.PictureBox ChannelOne_PosOfs_SmallDownButton;              //  Channel One Position Offset Small Down Button
        private System.Windows.Forms.PictureBox ChannelOne_PosOfs_SmallUpButton;                //  Channel One Position Offset Small Up Button
        private System.Windows.Forms.PictureBox ChannelOne_PosOfs_DefaultButton;                //  Channel One Position Offset Default Button
        private System.Windows.Forms.PictureBox ChannelOne_PosOfs_BigDownButton;                //  Channel One Position Offset Big Down Button
        private System.Windows.Forms.PictureBox ChannelOne_PosOfs_BigUpButton;                  //  Channel One Position Offset Big Up Button
        private System.Windows.Forms.PictureBox ChannelOne_PosOfs_StatusBar;                    //  Channel One Position Offset Status Bar

        //  Channel Two
        private System.Windows.Forms.TextBox ChannelTwo_TextBox;                                //  Channel Two TextBox
        private System.Windows.Forms.PictureBox ChannelTwo_Button;                              //  Channel Two Button
        private System.Windows.Forms.PictureBox ChannelTwo_SmallDownButton;                     //  Channel Two Small Down Button
        private System.Windows.Forms.PictureBox ChannelTwo_SmallUpButton;                       //  Channel Two Small Up Button
        private System.Windows.Forms.PictureBox ChannelTwo_DefaultButton;                       //  Channel Two Default Button
        private System.Windows.Forms.PictureBox ChannelTwo_BigDownButton;                       //  Channel Two Big Down Button
        private System.Windows.Forms.PictureBox ChannelTwo_BigUpButton;                         //  Channel Two Big Up Button
        private System.Windows.Forms.PictureBox ChannelTwo_StatusBar;                           //  Channel Two Status Bar

        //  Channel Two Position Offset
        private System.Windows.Forms.TextBox ChannelTwo_PosOfs_TextBox;                         //  Channel Two Position Offset TextBox
        private System.Windows.Forms.PictureBox ChannelTwo_PositionButton;                      //  Channel Two Position Button
        private System.Windows.Forms.PictureBox ChannelTwo_OffsetButton;                        //  Channel Two Offset Button
        private System.Windows.Forms.PictureBox ChannelTwo_PosOfs_SmallDownButton;              //  Channel Two Position Offset Small Down Button
        private System.Windows.Forms.PictureBox ChannelTwo_PosOfs_SmallUpButton;                //  Channel Two Position Offset Small Up Button
        private System.Windows.Forms.PictureBox ChannelTwo_PosOfs_DefaultButton;                //  Channel Two Position Offset Default Button
        private System.Windows.Forms.PictureBox ChannelTwo_PosOfs_BigDownButton;                //  Channel Two Position Offset Big Down Button
        private System.Windows.Forms.PictureBox ChannelTwo_PosOfs_BigUpButton;                  //  Channel Two Position Offset Big Up Button
        private System.Windows.Forms.PictureBox ChannelTwo_PosOfs_StatusBar;                    //  Channel Two Position Offset Status Bar

        //  Channel Three
        private System.Windows.Forms.TextBox ChannelThree_TextBox;                              //  Channel Three TextBox
        private System.Windows.Forms.PictureBox ChannelThree_Button;                            //  Channel Three Button
        private System.Windows.Forms.PictureBox ChannelThree_SmallDownButton;                   //  Channel Three Small Down Button
        private System.Windows.Forms.PictureBox ChannelThree_SmallUpButton;                     //  Channel Three Small Up Button
        private System.Windows.Forms.PictureBox ChannelThree_DefaultButton;                     //  Channel Three Default Button
        private System.Windows.Forms.PictureBox ChannelThree_BigDownButton;                     //  Channel Three Big Down Button
        private System.Windows.Forms.PictureBox ChannelThree_BigUpButton;                       //  Channel Three Big Up Button
        private System.Windows.Forms.PictureBox ChannelThree_StatusBar;                         //  Channel Three Status Bar

        //  Channel Three Position Offset
        private System.Windows.Forms.TextBox ChannelThree_PosOfs_TextBox;                       //  Channel Three Position Offset TextBox
        private System.Windows.Forms.PictureBox ChannelThree_PositionButton;                    //  Channel Three Position Button
        private System.Windows.Forms.PictureBox ChannelThree_OffsetButton;                      //  Channel Three Offset Button
        private System.Windows.Forms.PictureBox ChannelThree_PosOfs_SmallDownButton;            //  Channel Three Position Offset Small Down Button
        private System.Windows.Forms.PictureBox ChannelThree_PosOfs_SmallUpButton;              //  Channel Three Position Offset Small Up Button
        private System.Windows.Forms.PictureBox ChannelThree_PosOfs_DefaultButton;              //  Channel Three Position Offset Default Button
        private System.Windows.Forms.PictureBox ChannelThree_PosOfs_BigDownButton;              //  Channel Three Position Offset Big Down Button
        private System.Windows.Forms.PictureBox ChannelThree_PosOfs_BigUpButton;                //  Channel Three Position Offset Big Up Button
        private System.Windows.Forms.PictureBox ChannelThree_PosOfs_StatusBar;                  //  Channel Three Position Offset Status Bar

        //  Channel Four
        private System.Windows.Forms.TextBox ChannelFour_TextBox;                               //  Channel Four TextBox
        private System.Windows.Forms.PictureBox ChannelFour_Button;                             //  Channel Four Button
        private System.Windows.Forms.PictureBox ChannelFour_SmallDownButton;                    //  Channel Four Small Down Button
        private System.Windows.Forms.PictureBox ChannelFour_SmallUpButton;                      //  Channel Four Small Up Button
        private System.Windows.Forms.PictureBox ChannelFour_DefaultButton;                      //  Channel Four Default Button
        private System.Windows.Forms.PictureBox ChannelFour_BigDownButton;                      //  Channel Four Big Down Button
        private System.Windows.Forms.PictureBox ChannelFour_BigUpButton;                        //  Channel Four Big Up Button
        private System.Windows.Forms.PictureBox ChannelFour_StatusBar;                          //  Channel Four Status Bar

        //  Channel Four Position Offset
        private System.Windows.Forms.TextBox ChannelFour_PosOfs_TextBox;                        //  Channel Four Position Offset TextBox
        private System.Windows.Forms.PictureBox ChannelFour_PositionButton;                     //  Channel Four Position Button
        private System.Windows.Forms.PictureBox ChannelFour_OffsetButton;                       //  Channel Four Offset Button
        private System.Windows.Forms.PictureBox ChannelFour_PosOfs_SmallDownButton;             //  Channel Four Position Offset Small Down Button
        private System.Windows.Forms.PictureBox ChannelFour_PosOfs_SmallUpButton;               //  Channel Four Position Offset Small Up Button
        private System.Windows.Forms.PictureBox ChannelFour_PosOfs_DefaultButton;               //  Channel Four Position Offset Default Button
        private System.Windows.Forms.PictureBox ChannelFour_PosOfs_BigDownButton;               //  Channel Four Position Offset Big Down Button
        private System.Windows.Forms.PictureBox ChannelFour_PosOfs_BigUpButton;                 //  Channel Four Position Offset Big Up Button
        private System.Windows.Forms.PictureBox ChannelFour_PosOfs_StatusBar;                   //  Channel Four Position Offset Status Bar

        //  Timebase
        private System.Windows.Forms.TextBox timebase_TextBox;                                  //  Timebase TextBox
        private System.Windows.Forms.PictureBox timebase_StatusBar;                             //  Timebase Status Bar
        private System.Windows.Forms.PictureBox timebase_BigLeftButton;                         //  Timebase Big Left Button
        private System.Windows.Forms.PictureBox timebase_BigRightButton;                        //  Timebase Big Right Button
        private System.Windows.Forms.PictureBox timebase_DefaultButton;                         //  Timebase Default Button
        private System.Windows.Forms.PictureBox timebase_SmallLeftButton;                       //  Timebase Small Left Button
        private System.Windows.Forms.PictureBox timebase_SmallRightButton;                      //  Timebase Small Right Button

        //  Timabase Position Delay
        private System.Windows.Forms.TextBox timebase_PosDelay_TextBox;                         //  Timebase Position Delay TextBox
        private System.Windows.Forms.PictureBox timebase_PosDelay_StatusBar;                    //  Timebase Position Delay Status Bar
        private System.Windows.Forms.PictureBox timebase_PosDelay_SmallLeftButton;              //  Timebase Position Delay Small Left Button
        private System.Windows.Forms.PictureBox timebase_PosDelay_SmallRightButton;             //  Timebase Position Delay Small Right Button
        private System.Windows.Forms.PictureBox timebase_PosDelay_DefaultButton;                //  Timebase Position Delay Default Button
        private System.Windows.Forms.PictureBox timebase_PosDelay_BigLeftButton;                //  Timebase Position Delay Big Left Button
        private System.Windows.Forms.PictureBox timebase_PosDelay_BigRightButton;               //  Timebase Position Delay 
        private System.Windows.Forms.PictureBox timebase_DelayButton;                           //  Timebase Delay Button
        private System.Windows.Forms.PictureBox timebase_PositionButton;                        //  Timebase Position Button

        //  Trigger Mode
        private System.Windows.Forms.PictureBox triggerMode_TriggeredButton;                    //  Trigger Mode Triggered Button
        private System.Windows.Forms.PictureBox triggerMode_FreerunButton;                      //  Trigger Mode Freerun Button

        //  Trigger Level
        private System.Windows.Forms.TextBox triggerLevel_TextBox;                              //  Trigger Level TextBox
        private System.Windows.Forms.PictureBox triggerLevel_StatusBar;                         //  Trigger Level Status Bar
        private System.Windows.Forms.PictureBox triggerLevel_SmallDownButton;                   //  Trigger Level Small Down Button
        private System.Windows.Forms.PictureBox triggerLevel_SmallUpButton;                     //  Trigger Level Small Up Button
        private System.Windows.Forms.PictureBox triggerLevel_ZeroButton;                        //  Trigger Level Zero Button
        private System.Windows.Forms.PictureBox triggerLevel_BigDownButton;                     //  Trigger Level Big Down Button
        private System.Windows.Forms.PictureBox triggerLevel_BigUpButton;                       //  Trigger Level Big Up Button

        //  Trigger Source
        private System.Windows.Forms.PictureBox triggerSource_ChannelOne;                       //  Trigger Source Channel One
        private System.Windows.Forms.PictureBox triggerSource_ChannelTwo;                       //  Trigger Source Channel Two
        private System.Windows.Forms.PictureBox triggerSource_ChannelThree;                     //  Trigger Source Channel Three
        private System.Windows.Forms.PictureBox triggerSource_ChannelFour;                      //  Trigger Source Channel Four

        //  Trigger Slope
        private System.Windows.Forms.PictureBox triggerSlope_Positive;                          //  Trigger Slope Positive
        private System.Windows.Forms.PictureBox triggerSlope_Negative;                          //  Trigger Slope Negative
        private System.Windows.Forms.PictureBox triggerSlope_Bislope;                           //  Trigger Slope Bislope

        //  Down Menu Panel
        private System.Windows.Forms.Panel downMenuPanel;                                       //  Down Menu Panel

        //  Down Menu Icons and Buttons
        private System.Windows.Forms.PictureBox downMenu_LeftMouseIcon;                         //  Left Mouse Icon
        private System.Windows.Forms.PictureBox downMenu_ChannelsButton;                        //  Channels Button
        private System.Windows.Forms.PictureBox downMenu_AcquireButton;                         //  Acquire Button
        private System.Windows.Forms.PictureBox downMenu_TriggerButton;                         //  Trigger Button
        private System.Windows.Forms.PictureBox downMenu_DisplayButton;                         //  Display Button
        private System.Windows.Forms.PictureBox downMenu_SaveButton;                            //  Save Button
        private System.Windows.Forms.PictureBox downMenu_MarkerButton;                          //  Marker Button
        private System.Windows.Forms.PictureBox downMenu_MeasureButton;                         //  Measure Button
        private System.Windows.Forms.PictureBox downMenu_MathButton;                            //  Math Button
        private System.Windows.Forms.PictureBox downMenu_RightMouseIcon;                        //  Right Mouse Icon
        private System.Windows.Forms.PictureBox downMenu_HistogramButton;                       //  Histogram Button
        private System.Windows.Forms.PictureBox downMenu_DiagramButton;                         //  Diagram Button
        private System.Windows.Forms.PictureBox downMenu_MaskButton;                            //  Mask Button
        private System.Windows.Forms.PictureBox downMenu_EmptyButtons;                          //  Empty Buttons
        private System.Windows.Forms.PictureBox downMenu_UtilityButton;                         //  Utility Button
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private OpenTK.GLControl glControl1;
    }
}

