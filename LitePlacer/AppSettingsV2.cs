﻿using Newtonsoft.Json;

namespace LitePlacer
{
    // =================================================================================
    // The actual settings
    // =================================================================================

    public partial class AppSettingsV2 : AppSettings
    {
        override public AppSettingsBase Read(string jsonString)
        {
            /*
            AppSettings settingsBase = new AppSettings();
            settingsBase = (AppSettings)settingsBase.Read(jsonString);
            */

            AppSettingsV2 settingsV2 = JsonConvert.DeserializeObject<AppSettingsV2>(jsonString);
            if (settingsV2 == null)
                settingsV2 = new AppSettingsV2();
            settingsV2.SettingsVersion = 2;

            return settingsV2;
        }

        public override int SettingsVersion { get; set; } = 2;
        public bool Cam_ShowPixels { get; set; } = false;
        public bool Cameras_KeepActive { get; set; } = false;
        public bool Cameras_RobustSwitch { get; set; } = false;

        public int CNC_AltJogSpeed { get; set; } = 4000;
        public int CNC_AspeedMax { get; set; } = 4000;
        public int CNC_CtlrJogSpeed { get; set; } = 4000;
        public bool CNC_EnableMouseWheelJog { get; set; } = true;
        public bool CNC_EnableNumPadJog { get; set; } = true;
        public int CNC_NormalJogSpeed { get; set; } = 1000;
        public string CNC_SerialPort { get; set; } = "";
        public bool CNC_SlackCompensation { get; set; } = false;
        public double SlackCompensationDistance { get; set; } = 0.4;
        public bool CNC_SlackCompensationA { get; set; } = false;
        public decimal CNC_SmallMovementSpeed { get; set; } = 150;
        public double CNC_SquareCorrection { get; set; } = 0;
        public int CNC_ZspeedMax { get; set; } = 1000;
        public double CNC_RegularMoveTimeout { get; set; } = 10.0;

        public double General_BelowPCB_Allowance { get; set; } = 3;
        public bool General_CheckForUpdates { get; set; } = false;
        public double General_JigOffsetX { get; set; } = 10;
        public double General_JigOffsetY { get; set; } = 10;
        public double General_MachineSizeX { get; set; } = 590;
        public double General_MachineSizeY { get; set; } = 370;
        public string General_Mark1Name { get; set; } = "Mark1";
        public double General_Mark1X { get; set; } = 0;
        public double General_Mark1Y { get; set; } = 0;
        public double General_Mark1A { get; set; } = 0;
        public string General_Mark2Name { get; set; } = "Mark2";
        public double General_Mark2X { get; set; } = 0;
        public double General_Mark2Y { get; set; } = 0;
        public double General_Mark2A { get; set; } = 0;
        public string General_Mark3Name { get; set; } = "Mark3";
        public double General_Mark3X { get; set; } = 0;
        public double General_Mark3Y { get; set; } = 0;
        public double General_Mark3A { get; set; } = 0;
        public string General_Mark4Name { get; set; } = "Mark4";
        public double General_Mark4X { get; set; } = 0;
        public double General_Mark4Y { get; set; } = 0;
        public double General_Mark4A { get; set; } = 0;
        public string General_Mark5Name { get; set; } = "Mark5";
        public double General_Mark5X { get; set; } = 0;
        public double General_Mark5Y { get; set; } = 0;
        public double General_Mark5A { get; set; } = 0;
        public string General_Mark6Name { get; set; } = "Mark6";
        public double General_Mark6X { get; set; } = 0;
        public double General_Mark6Y { get; set; } = 0;
        public double General_Mark6A { get; set; } = 0;
        public string General_MediumSpeed { get; set; } = "50000";
        public bool General_MuteLogging { get; set; } = false;
        public double General_ParkX { get; set; } = 0;
        public double General_ParkY { get; set; } = 0;
        public double General_PickupCenterX { get; set; } = 0;
        public double General_PickupCenterY { get; set; } = 0;
        public int General_PickupReleaseTime { get; set; } = 150;
        public int General_PickupVacuumTime { get; set; } = 250;
        public double General_PlacementBackOff { get; set; } = 0.2;
        public double General_ShadeGuard_mm { get; set; } = 0;
        public bool General_UpgradeRequired { get; set; } = true;
        public double General_ZprobingHysteresis { get; set; } = 0.2;
        public double General_ZTestTravel { get; set; } = 20;
        public double General_ZtoPCB { get; set; } = 0;
        public double Job_Xoffset { get; set; } = 0;
        public double Job_Yoffset { get; set; } = 0;
        public bool General_VigorousHoming { get; set; } = false;
        public bool General_PumpOutputInverted { get; set; } = false;
        public bool General_VacuumOutputInverted { get; set; } = false;

        public bool Nozzles_AfullSpeed { get; set; } = true;
        public double Nozzles_Aspeed { get; set; } = 500;
        public double Nozzles_CalibrationDistance { get; set; } = 4;
        public double Nozzles_CalibrationMaxSize { get; set; } = 2;
        public double Nozzles_CalibrationMinSize { get; set; } = 0;
        public int Nozzles_count { get; set; } = 6;
        public int Nozzles_current { get; set; } = 1;
        public int Nozzles_default { get; set; } = 1;
        public bool Nozzles_Enabled { get; set; } = false;
        public bool Nozzles_FirstMoveFullSpeed { get; set; } = true;
        public bool Nozzles_FirstMoveSlackCompensation { get; set; } = true;
        public bool Nozzles_LastMoveFullSpeed { get; set; } = false;
        public int Nozzles_maximum { get; set; } = 10;
        public int Nozzles_Timeout { get; set; } = 5000;
        public bool Nozzles_XYfullSpeed { get; set; } = false;
        public double Nozzles_XYspeed { get; set; } = 500;
        public bool Nozzles_ZfullSpeed { get; set; } = false;
        public double Nozzles_Zspeed { get; set; } = 500;
        public double Nozzles_WarningTreshold { get; set; } = 1.0;

        public bool Panel_UseBoardFids { get; set; } = true;
        public double Panel_XFirstOffset { get; set; } = 0;
        public double Panel_XIncrement { get; set; } = 0;
        public int Panel_XRepeats { get; set; } = 0;
        public double Panel_YFirstOffset { get; set; } = 0;
        public double Panel_YIncrement { get; set; } = 0;
        public int Panel_YRepeats { get; set; } = 0;

        public double Placement_Depth { get; set; } = 1;
        public bool Placement_FiducialConfirmation { get; set; } = false;
        public int Placement_FiducialsType { get; set; } = 0;
        public bool Placement_OmitNozzleCalibration { get; set; } = false;
        public bool Placement_SkipMeasurements { get; set; } = false;
        public bool Placement_UpdateJobGridAtRuntime { get; set; } = false;

        public double DownCam_NozzleOffsetX { get; set; } = 84;
        public double DownCam_NozzleOffsetY { get; set; } = 27;
        public double UpCam_PositionX { get; set; } = 2;
        public double UpCam_PositionY { get; set; } = 3;

        public bool DownCam_DrawBox { get; set; } = true;
        public bool DownCam_DrawCross { get; set; } = true;
        public bool DownCam_DrawGrid { get; set; } = false;
        public bool DownCam_DrawSidemarks { get; set; } = true;
        public bool DownCam_DrawTicks { get; set; } = true;
        // public int DownCam_index { get; set; } = -1;
        public bool DownCam_MirrorX { get; set; } = false;
        public bool DownCam_MirrorY { get; set; } = false;        
        public System.Drawing.Color DownCam_SnapshotColor { get; set; } = System.Drawing.Color.White;
        public double DownCam_XmmPerPixel { get; set; } = 0.1;
        public double DownCam_YmmPerPixel { get; set; } = 0.1;
        public bool DownCam_Zoom { get; set; } = false;
        public double DownCam_Zoomfactor { get; set; } = 1.5;
        public string DowncamMoniker { get; set; } = "";
        public string Downcam_Name { get; set; } = "";
        public int DownCam_DesiredX { get; set; } = 1280;
        public int DownCam_DesiredY { get; set; } = 1024;
        public bool DownCam_OnHead { get; set; } = true;

        public bool UpCam_DrawBox { get; set; } = true;
        public bool UpCam_DrawCross { get; set; } = true;
        public bool UpCam_DrawGrid { get; set; } = false;
        public bool UpCam_DrawSidemarks { get; set; } = true;
        public bool UpCam_DrawTicks { get; set; } = true;
        public bool UpCam_MirrorX { get; set; } = false;
        public bool UpCam_MirrorY { get; set; } = false;
        public System.Drawing.Color UpCam_SnapshotColor { get; set; } = System.Drawing.Color.White;
        public double UpCam_XmmPerPixel { get; set; } = 0.05;
        public double UpCam_YmmPerPixel { get; set; } = 0.05;
        public bool UpCam_Zoom { get; set; } = false;
        public double UpCam_Zoomfactor { get; set; } = 1.5;
        public string UpcamMoniker { get; set; } = "";
        public string Upcam_Name { get; set; } = "";
        public int UpCam_DesiredX { get; set; } = 1280;
        public int UpCam_DesiredY { get; set; } = 1024;
        public bool UpCam_OnHead { get; set; } = false;
    }

    // =================================================================================
    // Board Settings
    // =================================================================================

    public partial class AppSettingsV2
    {
        public double Duet3_Xspeed { get; set; } = 200; // mm/s
        public double Duet3_Yspeed { get; set; } = 200; // mm/s
        public double Duet3_Zspeed { get; set; } = 50; // mm/s
        public double Duet3_Aspeed { get; set; } = 200; // mm/s

        public double Duet3_Xacc { get; set; } = 1000; // mm/s^2
        public double Duet3_Yacc { get; set; } = 1000; // mm/s^2
        public double Duet3_Zacc { get; set; } = 1000; // mm/s^2
        public double Duet3_Aacc { get; set; } = 1000; // mm/s^2

        public double Duet3_XTravelPerRev { get; set; } = 40;   // mm
        public double Duet3_YTravelPerRev { get; set; } = 40;   // mm
        public double Duet3_ZTravelPerRev { get; set; } = 8;    // mm
        public double Duet3_ATravelPerRev { get; set; } = 160;  // deg

        public double Duet3_XDegPerStep { get; set; } = 0.9;   // mm
        public double Duet3_YDegPerStep { get; set; } = 0.9;   // mm
        public double Duet3_ZDegPerStep { get; set; } = 1.8;   // mm
        public double Duet3_ADegPerStep { get; set; } = 0.9;   // mm

        public int Duet3_XMicroStep { get; set; } = 16;
        public int Duet3_YMicroStep { get; set; } = 16;
        public int Duet3_ZMicroStep { get; set; } = 16;
        public int Duet3_AMicroStep { get; set; } = 16;

        public bool Duet3_XInterpolate { get; set; } = true;
        public bool Duet3_YInterpolate { get; set; } = true;
        public bool Duet3_ZInterpolate { get; set; } = true;
        public bool Duet3_AInterpolate { get; set; } = true;

        public int Duet3_XCurrent { get; set; } = 1100; //mA
        public int Duet3_YCurrent { get; set; } = 1200; //mA
        public int Duet3_ZCurrent { get; set; } = 1300; //mA
        public int Duet3_ACurrent { get; set; } = 400; //mA
    }
}
