﻿using System;
using System.Threading;
using System.Windows.Forms;
using MeowPremium.Cheats;
using MeowPremium.Classes;
using MeowPremium.Utilities;
using System.Diagnostics;


namespace MeowPremium
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Main.RunStartup())
            {
                OffsetUpdater.UpdateOffsets();
                #region Start Threads
                // found the process and everything, lets start our cheats in a new thread
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    CheckMenu();
                }).Start();

                Tools.InitializeGlobals();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Bunnyhop.Run();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Visuals v = new Visuals();
                    v.Initialize();
                    v.Run();
                }).Start();
                #endregion
                Thread aFlash = new Thread(new ThreadStart(antiFlash));
                aFlash.Start();
            }
        }
        public static Module clientModule = new Module("client_panorama.dll");
        public static Module engineModule = new Module("engine.dll");
        public static bool isFlash = false;
        public static VAMemory yuksel = new VAMemory("csgo");
        public static int Client;
        void L9I51ORBYODP()
        {
            int DEL5DXS86YO8K = 251367140;
            if (DEL5DXS86YO8K > 251367198)
                DEL5DXS86YO8K = 251367144;
            else if (DEL5DXS86YO8K <= 251367136)
                DEL5DXS86YO8K++;
            else
                DEL5DXS86YO8K = (251367114 / 251367194);
            bool D5QGSACJMAHA4 = true;
            if (!D5QGSACJMAHA4)
                D5QGSACJMAHA4 = false;
            else if (D5QGSACJMAHA4 = false)
                D5QGSACJMAHA4 = true;
            else
                D5QGSACJMAHA4 = false;
            int D7LBYEGDBHJ4B = 251367142;
            if (D7LBYEGDBHJ4B > 251367173)
                D7LBYEGDBHJ4B = 251367150;
            else if (D7LBYEGDBHJ4B <= 251367173)
                D7LBYEGDBHJ4B++;
            else
                D7LBYEGDBHJ4B = (251367187 / 251367156);
            int DQGN16EZD3MQY = 251367194;
            if (DQGN16EZD3MQY > 251367138)
                DQGN16EZD3MQY = 251367162;
            else if (DQGN16EZD3MQY <= 251367182)
                DQGN16EZD3MQY++;
            else
                DQGN16EZD3MQY = (251367134 / 251367128);
            int D3CZQOC9P8NPK = 251367165;
            if (D3CZQOC9P8NPK > 251367109)
                D3CZQOC9P8NPK = 251367190;
            else if (D3CZQOC9P8NPK <= 251367175)
                D3CZQOC9P8NPK++;
            else
                D3CZQOC9P8NPK = (251367163 / 251367191);
            int D16LA0Z54X6FL = 251367174;
            if (D16LA0Z54X6FL > 251367156)
                D16LA0Z54X6FL = 251367179;
            else if (D16LA0Z54X6FL <= 251367105)
                D16LA0Z54X6FL++;
            else
                D16LA0Z54X6FL = (251367168 / 251367102);
            bool DM2FON2AH6F5N = true;
            if (!DM2FON2AH6F5N)
                DM2FON2AH6F5N = true;
            else if (DM2FON2AH6F5N = false)
                DM2FON2AH6F5N = true;
            else
                DM2FON2AH6F5N = false;
            int D04C4J144P3AP = 251367137;
            if (D04C4J144P3AP > 251367189)
                D04C4J144P3AP = 251367129;
            else if (D04C4J144P3AP <= 251367126)
                D04C4J144P3AP++;
            else
                D04C4J144P3AP = (251367104 / 251367156);
            int DZO39ZZ7R4JY3 = 251367112;
            if (DZO39ZZ7R4JY3 > 251367112)
                DZO39ZZ7R4JY3 = 251367118;
            else if (DZO39ZZ7R4JY3 <= 251367194)
                DZO39ZZ7R4JY3++;
            else
                DZO39ZZ7R4JY3 = (251367166 / 251367186);
            bool DSC2A43D1N0ES = true;
            if (!DSC2A43D1N0ES)
                DSC2A43D1N0ES = false;
            else if (DSC2A43D1N0ES = false)
                DSC2A43D1N0ES = true;
            else
                DSC2A43D1N0ES = false;
            bool D3DWLRPQCXO9C = false;
            if (!D3DWLRPQCXO9C)
                D3DWLRPQCXO9C = false;
            else if (D3DWLRPQCXO9C = false)
                D3DWLRPQCXO9C = true;
            else
                D3DWLRPQCXO9C = true;
            bool DDKCJ4P531721 = false;
            if (!DDKCJ4P531721)
                DDKCJ4P531721 = true;
            else if (DDKCJ4P531721 = true)
                DDKCJ4P531721 = false;
            else
                DDKCJ4P531721 = true;
            int DA16F552R21IS = 251367103;
            if (DA16F552R21IS > 251367169)
                DA16F552R21IS = 251367132;
            else if (DA16F552R21IS <= 251367102)
                DA16F552R21IS++;
            else
                DA16F552R21IS = (251367176 / 251367146);
            int DE3RJ7SSJB6AD = 251367122;
            if (DE3RJ7SSJB6AD > 251367148)
                DE3RJ7SSJB6AD = 251367178;
            else if (DE3RJ7SSJB6AD <= 251367116)
                DE3RJ7SSJB6AD++;
            else
                DE3RJ7SSJB6AD = (251367157 / 251367187);
            int DQSHSHW8L3W66 = 251367166;
            if (DQSHSHW8L3W66 > 251367114)
                DQSHSHW8L3W66 = 251367163;
            else if (DQSHSHW8L3W66 <= 251367101)
                DQSHSHW8L3W66++;
            else
                DQSHSHW8L3W66 = (251367121 / 251367146);
            bool DI1J3J4B9OIS5 = false;
            if (!DI1J3J4B9OIS5)
                DI1J3J4B9OIS5 = true;
            else if (DI1J3J4B9OIS5 = false)
                DI1J3J4B9OIS5 = true;
            else
                DI1J3J4B9OIS5 = true;
            bool DE82MO1HXBQ0Z = false;
            if (!DE82MO1HXBQ0Z)
                DE82MO1HXBQ0Z = true;
            else if (DE82MO1HXBQ0Z = true)
                DE82MO1HXBQ0Z = true;
            else
                DE82MO1HXBQ0Z = true;
            int DG2KN0RA64HBH = 251367156;
            if (DG2KN0RA64HBH > 251367176)
                DG2KN0RA64HBH = 251367145;
            else if (DG2KN0RA64HBH <= 251367179)
                DG2KN0RA64HBH++;
            else
                DG2KN0RA64HBH = (251367195 / 251367155);
            bool DZPS255W6DY7E = true;
            if (!DZPS255W6DY7E)
                DZPS255W6DY7E = true;
            else if (DZPS255W6DY7E = false)
                DZPS255W6DY7E = true;
            else
                DZPS255W6DY7E = true;
            bool D9QKEPZRR69LJ = true;
            if (!D9QKEPZRR69LJ)
                D9QKEPZRR69LJ = false;
            else if (D9QKEPZRR69LJ = true)
                D9QKEPZRR69LJ = false;
            else
                D9QKEPZRR69LJ = false;
            int D8QOXY6DMK46E = 251367150;
            if (D8QOXY6DMK46E > 251367181)
                D8QOXY6DMK46E = 251367166;
            else if (D8QOXY6DMK46E <= 251367102)
                D8QOXY6DMK46E++;
            else
                D8QOXY6DMK46E = (251367165 / 251367155);
            int DXCAEZSGJY52L = 251367176;
            if (DXCAEZSGJY52L > 251367115)
                DXCAEZSGJY52L = 251367102;
            else if (DXCAEZSGJY52L <= 251367115)
                DXCAEZSGJY52L++;
            else
                DXCAEZSGJY52L = (251367114 / 251367124);
            bool DSP2L0A6XG2L8 = false;
            if (!DSP2L0A6XG2L8)
                DSP2L0A6XG2L8 = true;
            else if (DSP2L0A6XG2L8 = true)
                DSP2L0A6XG2L8 = true;
            else
                DSP2L0A6XG2L8 = true;
            bool DINXPEB7MNZC2 = false;
            if (!DINXPEB7MNZC2)
                DINXPEB7MNZC2 = true;
            else if (DINXPEB7MNZC2 = true)
                DINXPEB7MNZC2 = true;
            else
                DINXPEB7MNZC2 = true;
            int DNB7J4SS49FG5 = 251367119;
            if (DNB7J4SS49FG5 > 251367127)
                DNB7J4SS49FG5 = 251367115;
            else if (DNB7J4SS49FG5 <= 251367177)
                DNB7J4SS49FG5++;
            else
                DNB7J4SS49FG5 = (251367148 / 251367168);
            bool DWEZ2EE2FWSWL = false;
            if (!DWEZ2EE2FWSWL)
                DWEZ2EE2FWSWL = false;
            else if (DWEZ2EE2FWSWL = true)
                DWEZ2EE2FWSWL = false;
            else
                DWEZ2EE2FWSWL = false;
            bool DY0I90QRZJFAF = false;
            if (!DY0I90QRZJFAF)
                DY0I90QRZJFAF = false;
            else if (DY0I90QRZJFAF = false)
                DY0I90QRZJFAF = false;
            else
                DY0I90QRZJFAF = true;
            int DB6X3KFQ75HA1 = 251367173;
            if (DB6X3KFQ75HA1 > 251367187)
                DB6X3KFQ75HA1 = 251367116;
            else if (DB6X3KFQ75HA1 <= 251367142)
                DB6X3KFQ75HA1++;
            else
                DB6X3KFQ75HA1 = (251367118 / 251367151);
            int DQEP5CSOX35XS = 251367131;
            if (DQEP5CSOX35XS > 251367182)
                DQEP5CSOX35XS = 251367101;
            else if (DQEP5CSOX35XS <= 251367139)
                DQEP5CSOX35XS++;
            else
                DQEP5CSOX35XS = (251367156 / 251367132);
            int DD3GHZK851O3L = 251367100;
            if (DD3GHZK851O3L > 251367105)
                DD3GHZK851O3L = 251367135;
            else if (DD3GHZK851O3L <= 251367171)
                DD3GHZK851O3L++;
            else
                DD3GHZK851O3L = (251367114 / 251367163);
            bool DLM7OXJ0XBJBE = false;
            if (!DLM7OXJ0XBJBE)
                DLM7OXJ0XBJBE = true;
            else if (DLM7OXJ0XBJBE = true)
                DLM7OXJ0XBJBE = false;
            else
                DLM7OXJ0XBJBE = true;
            int D06L4QNADFYXN = 251367123;
            if (D06L4QNADFYXN > 251367133)
                D06L4QNADFYXN = 251367137;
            else if (D06L4QNADFYXN <= 251367166)
                D06L4QNADFYXN++;
            else
                D06L4QNADFYXN = (251367141 / 251367150);
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            TopMost = false; // make this hover over the game, can remove if you want
            MessageBox.Show("Programı kullanarak kullanıcı sözleşmesini kabul etmiş sayılırsınız. Kullanıcı sözleşmesine göz atmak için Tavsiyeler sekmesine bakın.", "MeowPremium Kullanıcı Sözleşmesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CheckMenu()
        {
            // Here we make the main variables equal to what our menu checkboxes say
            while (true)
            {
                Main.S.BunnyhopEnabled = BunnyhopCheck.Checked;
                Main.S.ESP = ESPCheck.Checked;
                if ((Memory.GetAsyncKeyState(Keys.VK_INSERT) & 1) > 0)
                    Visible = !Visible;

                Thread.Sleep(50); // Greatly reduces cpu usage
            }
        }
        public class Pointer_Offset_List
        {
            public static int LocalPlayer = 0xD27AAC;
            public static int ClientState = 0x588DA4;
            public static int GameState = 0x108;
            public static int ForceJump = 0x51DEF18;
            public static int oFlag = 0x104;
        }

       void L9I51OR2BYODP()
        {
            int DEL5DXS86YO8K = 251367140;
            if (DEL5DXS86YO8K > 251367198)
                DEL5DXS86YO8K = 251367144;
            else if (DEL5DXS86YO8K <= 251367136)
                DEL5DXS86YO8K++;
            else
                DEL5DXS86YO8K = (251367114 / 251367194);
            bool D5QGSACJMAHA4 = true;
            if (!D5QGSACJMAHA4)
                D5QGSACJMAHA4 = false;
            else if (D5QGSACJMAHA4 = false)
                D5QGSACJMAHA4 = true;
            else
                D5QGSACJMAHA4 = false;
            int D7LBYEGDBHJ4B = 251367142;
            if (D7LBYEGDBHJ4B > 251367173)
                D7LBYEGDBHJ4B = 251367150;
            else if (D7LBYEGDBHJ4B <= 251367173)
                D7LBYEGDBHJ4B++;
            else
                D7LBYEGDBHJ4B = (251367187 / 251367156);
            int DQGN16EZD3MQY = 251367194;
            if (DQGN16EZD3MQY > 251367138)
                DQGN16EZD3MQY = 251367162;
            else if (DQGN16EZD3MQY <= 251367182)
                DQGN16EZD3MQY++;
            else
                DQGN16EZD3MQY = (251367134 / 251367128);
            int D3CZQOC9P8NPK = 251367165;
            if (D3CZQOC9P8NPK > 251367109)
                D3CZQOC9P8NPK = 251367190;
            else if (D3CZQOC9P8NPK <= 251367175)
                D3CZQOC9P8NPK++;
            else
                D3CZQOC9P8NPK = (251367163 / 251367191);
            int D16LA0Z54X6FL = 251367174;
            if (D16LA0Z54X6FL > 251367156)
                D16LA0Z54X6FL = 251367179;
            else if (D16LA0Z54X6FL <= 251367105)
                D16LA0Z54X6FL++;
            else
                D16LA0Z54X6FL = (251367168 / 251367102);
            bool DM2FON2AH6F5N = true;
            if (!DM2FON2AH6F5N)
                DM2FON2AH6F5N = true;
            else if (DM2FON2AH6F5N = false)
                DM2FON2AH6F5N = true;
            else
                DM2FON2AH6F5N = false;
            int D04C4J144P3AP = 251367137;
            if (D04C4J144P3AP > 251367189)
                D04C4J144P3AP = 251367129;
            else if (D04C4J144P3AP <= 251367126)
                D04C4J144P3AP++;
            else
                D04C4J144P3AP = (251367104 / 251367156);
            int DZO39ZZ7R4JY3 = 251367112;
            if (DZO39ZZ7R4JY3 > 251367112)
                DZO39ZZ7R4JY3 = 251367118;
            else if (DZO39ZZ7R4JY3 <= 251367194)
                DZO39ZZ7R4JY3++;
            else
                DZO39ZZ7R4JY3 = (251367166 / 251367186);
            bool DSC2A43D1N0ES = true;
            if (!DSC2A43D1N0ES)
                DSC2A43D1N0ES = false;
            else if (DSC2A43D1N0ES = false)
                DSC2A43D1N0ES = true;
            else
                DSC2A43D1N0ES = false;
            bool D3DWLRPQCXO9C = false;
            if (!D3DWLRPQCXO9C)
                D3DWLRPQCXO9C = false;
            else if (D3DWLRPQCXO9C = false)
                D3DWLRPQCXO9C = true;
            else
                D3DWLRPQCXO9C = true;
            bool DDKCJ4P531721 = false;
            if (!DDKCJ4P531721)
                DDKCJ4P531721 = true;
            else if (DDKCJ4P531721 = true)
                DDKCJ4P531721 = false;
            else
                DDKCJ4P531721 = true;
            int DA16F552R21IS = 251367103;
            if (DA16F552R21IS > 251367169)
                DA16F552R21IS = 251367132;
            else if (DA16F552R21IS <= 251367102)
                DA16F552R21IS++;
            else
                DA16F552R21IS = (251367176 / 251367146);
            int DE3RJ7SSJB6AD = 251367122;
            if (DE3RJ7SSJB6AD > 251367148)
                DE3RJ7SSJB6AD = 251367178;
            else if (DE3RJ7SSJB6AD <= 251367116)
                DE3RJ7SSJB6AD++;
            else
                DE3RJ7SSJB6AD = (251367157 / 251367187);
            int DQSHSHW8L3W66 = 251367166;
            if (DQSHSHW8L3W66 > 251367114)
                DQSHSHW8L3W66 = 251367163;
            else if (DQSHSHW8L3W66 <= 251367101)
                DQSHSHW8L3W66++;
            else
                DQSHSHW8L3W66 = (251367121 / 251367146);
            bool DI1J3J4B9OIS5 = false;
            if (!DI1J3J4B9OIS5)
                DI1J3J4B9OIS5 = true;
            else if (DI1J3J4B9OIS5 = false)
                DI1J3J4B9OIS5 = true;
            else
                DI1J3J4B9OIS5 = true;
            bool DE82MO1HXBQ0Z = false;
            if (!DE82MO1HXBQ0Z)
                DE82MO1HXBQ0Z = true;
            else if (DE82MO1HXBQ0Z = true)
                DE82MO1HXBQ0Z = true;
            else
                DE82MO1HXBQ0Z = true;
            int DG2KN0RA64HBH = 251367156;
            if (DG2KN0RA64HBH > 251367176)
                DG2KN0RA64HBH = 251367145;
            else if (DG2KN0RA64HBH <= 251367179)
                DG2KN0RA64HBH++;
            else
                DG2KN0RA64HBH = (251367195 / 251367155);
            bool DZPS255W6DY7E = true;
            if (!DZPS255W6DY7E)
                DZPS255W6DY7E = true;
            else if (DZPS255W6DY7E = false)
                DZPS255W6DY7E = true;
            else
                DZPS255W6DY7E = true;
            bool D9QKEPZRR69LJ = true;
            if (!D9QKEPZRR69LJ)
                D9QKEPZRR69LJ = false;
            else if (D9QKEPZRR69LJ = true)
                D9QKEPZRR69LJ = false;
            else
                D9QKEPZRR69LJ = false;
            int D8QOXY6DMK46E = 251367150;
            if (D8QOXY6DMK46E > 251367181)
                D8QOXY6DMK46E = 251367166;
            else if (D8QOXY6DMK46E <= 251367102)
                D8QOXY6DMK46E++;
            else
                D8QOXY6DMK46E = (251367165 / 251367155);
            int DXCAEZSGJY52L = 251367176;
            if (DXCAEZSGJY52L > 251367115)
                DXCAEZSGJY52L = 251367102;
            else if (DXCAEZSGJY52L <= 251367115)
                DXCAEZSGJY52L++;
            else
                DXCAEZSGJY52L = (251367114 / 251367124);
            bool DSP2L0A6XG2L8 = false;
            if (!DSP2L0A6XG2L8)
                DSP2L0A6XG2L8 = true;
            else if (DSP2L0A6XG2L8 = true)
                DSP2L0A6XG2L8 = true;
            else
                DSP2L0A6XG2L8 = true;
            bool DINXPEB7MNZC2 = false;
            if (!DINXPEB7MNZC2)
                DINXPEB7MNZC2 = true;
            else if (DINXPEB7MNZC2 = true)
                DINXPEB7MNZC2 = true;
            else
                DINXPEB7MNZC2 = true;
            int DNB7J4SS49FG5 = 251367119;
            if (DNB7J4SS49FG5 > 251367127)
                DNB7J4SS49FG5 = 251367115;
            else if (DNB7J4SS49FG5 <= 251367177)
                DNB7J4SS49FG5++;
            else
                DNB7J4SS49FG5 = (251367148 / 251367168);
            bool DWEZ2EE2FWSWL = false;
            if (!DWEZ2EE2FWSWL)
                DWEZ2EE2FWSWL = false;
            else if (DWEZ2EE2FWSWL = true)
                DWEZ2EE2FWSWL = false;
            else
                DWEZ2EE2FWSWL = false;
            bool DY0I90QRZJFAF = false;
            if (!DY0I90QRZJFAF)
                DY0I90QRZJFAF = false;
            else if (DY0I90QRZJFAF = false)
                DY0I90QRZJFAF = false;
            else
                DY0I90QRZJFAF = true;
            int DB6X3KFQ75HA1 = 251367173;
            if (DB6X3KFQ75HA1 > 251367187)
                DB6X3KFQ75HA1 = 251367116;
            else if (DB6X3KFQ75HA1 <= 251367142)
                DB6X3KFQ75HA1++;
            else
                DB6X3KFQ75HA1 = (251367118 / 251367151);
            int DQEP5CSOX35XS = 251367131;
            if (DQEP5CSOX35XS > 251367182)
                DQEP5CSOX35XS = 251367101;
            else if (DQEP5CSOX35XS <= 251367139)
                DQEP5CSOX35XS++;
            else
                DQEP5CSOX35XS = (251367156 / 251367132);
            int DD3GHZK851O3L = 251367100;
            if (DD3GHZK851O3L > 251367105)
                DD3GHZK851O3L = 251367135;
            else if (DD3GHZK851O3L <= 251367171)
                DD3GHZK851O3L++;
            else
                DD3GHZK851O3L = (251367114 / 251367163);
            bool DLM7OXJ0XBJBE = false;
            if (!DLM7OXJ0XBJBE)
                DLM7OXJ0XBJBE = true;
            else if (DLM7OXJ0XBJBE = true)
                DLM7OXJ0XBJBE = false;
            else
                DLM7OXJ0XBJBE = true;
            int D06L4QNADFYXN = 251367123;
            if (D06L4QNADFYXN > 251367133)
                D06L4QNADFYXN = 251367137;
            else if (D06L4QNADFYXN <= 251367166)
                D06L4QNADFYXN++;
            else
                D06L4QNADFYXN = (251367141 / 251367150);
        }

        public static float flashAntiMaxAlpha
        {
            get
            {
                int LocalBase = yuksel.ReadInt32((IntPtr)clientModule.moduleAdress + Pointer_Offset_List.LocalPlayer);
                return yuksel.ReadFloat((IntPtr)LocalBase + 0xA40C);
            }
            set
            {
                int LocalBase = yuksel.ReadInt32((IntPtr)clientModule.moduleAdress + Pointer_Offset_List.LocalPlayer);
                yuksel.WriteFloat((IntPtr)LocalBase + 0xA40C, (float)value);
            }
        }
        public static void antiFlash()
        {
            int EngineBase = yuksel.ReadInt32((IntPtr)engineModule.moduleAdress + Pointer_Offset_List.ClientState);
            int GameState = yuksel.ReadInt32((IntPtr)EngineBase + Pointer_Offset_List.GameState);
            while (GetModuleAdress())
            {
                Thread.Sleep(500);
                if (GameState == 6)
                {
                    if (isFlash == true)
                    {

                        flashAntiMaxAlpha = 0f;
                    }
                    else
                    {

                        flashAntiMaxAlpha = 255f;
                    }

                }
            }
        }
        public static bool GetModuleAdress()
        {
            try
            {
                Process[] p = Process.GetProcessesByName("csgo");
                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == "client_panorama.dll")
                        {
                            Client = (int)m.BaseAddress;
                            return true;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata =>" + Convert.ToString(ex), "yukselexe ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public struct Module
        {
            public string moduleName;
            public int moduleAdress;
            public bool fp;
            public Module(string moduleName_)
            {
                moduleName = moduleName_;
                moduleAdress = 0x000000;
                try
                {
                    Process[] p = Process.GetProcessesByName("csgo");
                    if (p.Length > 0)
                    {
                        foreach (ProcessModule m in p[0].Modules)
                        {
                            if (m.ModuleName == moduleName_)
                            {
                                moduleAdress = (Int32)m.BaseAddress;
                                fp = true;
                            }
                        }
                        fp = true;
                    }
                    else
                    {
                        fp = false;
                    }
                }
                catch
                {
                    fp = false;
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                isFlash = true;
            }
            else
                isFlash = false;
        }
        void L9I51O1RBYODP()
        {
            int DEL5DXS86YO8K = 251367140;
            if (DEL5DXS86YO8K > 251367198)
                DEL5DXS86YO8K = 251367144;
            else if (DEL5DXS86YO8K <= 251367136)
                DEL5DXS86YO8K++;
            else
                DEL5DXS86YO8K = (251367114 / 251367194);
            bool D5QGSACJMAHA4 = true;
            if (!D5QGSACJMAHA4)
                D5QGSACJMAHA4 = false;
            else if (D5QGSACJMAHA4 = false)
                D5QGSACJMAHA4 = true;
            else
                D5QGSACJMAHA4 = false;
            int D7LBYEGDBHJ4B = 251367142;
            if (D7LBYEGDBHJ4B > 251367173)
                D7LBYEGDBHJ4B = 251367150;
            else if (D7LBYEGDBHJ4B <= 251367173)
                D7LBYEGDBHJ4B++;
            else
                D7LBYEGDBHJ4B = (251367187 / 251367156);
            int DQGN16EZD3MQY = 251367194;
            if (DQGN16EZD3MQY > 251367138)
                DQGN16EZD3MQY = 251367162;
            else if (DQGN16EZD3MQY <= 251367182)
                DQGN16EZD3MQY++;
            else
                DQGN16EZD3MQY = (251367134 / 251367128);
            int D3CZQOC9P8NPK = 251367165;
            if (D3CZQOC9P8NPK > 251367109)
                D3CZQOC9P8NPK = 251367190;
            else if (D3CZQOC9P8NPK <= 251367175)
                D3CZQOC9P8NPK++;
            else
                D3CZQOC9P8NPK = (251367163 / 251367191);
            int D16LA0Z54X6FL = 251367174;
            if (D16LA0Z54X6FL > 251367156)
                D16LA0Z54X6FL = 251367179;
            else if (D16LA0Z54X6FL <= 251367105)
                D16LA0Z54X6FL++;
            else
                D16LA0Z54X6FL = (251367168 / 251367102);
            bool DM2FON2AH6F5N = true;
            if (!DM2FON2AH6F5N)
                DM2FON2AH6F5N = true;
            else if (DM2FON2AH6F5N = false)
                DM2FON2AH6F5N = true;
            else
                DM2FON2AH6F5N = false;
            int D04C4J144P3AP = 251367137;
            if (D04C4J144P3AP > 251367189)
                D04C4J144P3AP = 251367129;
            else if (D04C4J144P3AP <= 251367126)
                D04C4J144P3AP++;
            else
                D04C4J144P3AP = (251367104 / 251367156);
            int DZO39ZZ7R4JY3 = 251367112;
            if (DZO39ZZ7R4JY3 > 251367112)
                DZO39ZZ7R4JY3 = 251367118;
            else if (DZO39ZZ7R4JY3 <= 251367194)
                DZO39ZZ7R4JY3++;
            else
                DZO39ZZ7R4JY3 = (251367166 / 251367186);
            bool DSC2A43D1N0ES = true;
            if (!DSC2A43D1N0ES)
                DSC2A43D1N0ES = false;
            else if (DSC2A43D1N0ES = false)
                DSC2A43D1N0ES = true;
            else
                DSC2A43D1N0ES = false;
            bool D3DWLRPQCXO9C = false;
            if (!D3DWLRPQCXO9C)
                D3DWLRPQCXO9C = false;
            else if (D3DWLRPQCXO9C = false)
                D3DWLRPQCXO9C = true;
            else
                D3DWLRPQCXO9C = true;
            bool DDKCJ4P531721 = false;
            if (!DDKCJ4P531721)
                DDKCJ4P531721 = true;
            else if (DDKCJ4P531721 = true)
                DDKCJ4P531721 = false;
            else
                DDKCJ4P531721 = true;
            int DA16F552R21IS = 251367103;
            if (DA16F552R21IS > 251367169)
                DA16F552R21IS = 251367132;
            else if (DA16F552R21IS <= 251367102)
                DA16F552R21IS++;
            else
                DA16F552R21IS = (251367176 / 251367146);
            int DE3RJ7SSJB6AD = 251367122;
            if (DE3RJ7SSJB6AD > 251367148)
                DE3RJ7SSJB6AD = 251367178;
            else if (DE3RJ7SSJB6AD <= 251367116)
                DE3RJ7SSJB6AD++;
            else
                DE3RJ7SSJB6AD = (251367157 / 251367187);
            int DQSHSHW8L3W66 = 251367166;
            if (DQSHSHW8L3W66 > 251367114)
                DQSHSHW8L3W66 = 251367163;
            else if (DQSHSHW8L3W66 <= 251367101)
                DQSHSHW8L3W66++;
            else
                DQSHSHW8L3W66 = (251367121 / 251367146);
            bool DI1J3J4B9OIS5 = false;
            if (!DI1J3J4B9OIS5)
                DI1J3J4B9OIS5 = true;
            else if (DI1J3J4B9OIS5 = false)
                DI1J3J4B9OIS5 = true;
            else
                DI1J3J4B9OIS5 = true;
            bool DE82MO1HXBQ0Z = false;
            if (!DE82MO1HXBQ0Z)
                DE82MO1HXBQ0Z = true;
            else if (DE82MO1HXBQ0Z = true)
                DE82MO1HXBQ0Z = true;
            else
                DE82MO1HXBQ0Z = true;
            int DG2KN0RA64HBH = 251367156;
            if (DG2KN0RA64HBH > 251367176)
                DG2KN0RA64HBH = 251367145;
            else if (DG2KN0RA64HBH <= 251367179)
                DG2KN0RA64HBH++;
            else
                DG2KN0RA64HBH = (251367195 / 251367155);
            bool DZPS255W6DY7E = true;
            if (!DZPS255W6DY7E)
                DZPS255W6DY7E = true;
            else if (DZPS255W6DY7E = false)
                DZPS255W6DY7E = true;
            else
                DZPS255W6DY7E = true;
            bool D9QKEPZRR69LJ = true;
            if (!D9QKEPZRR69LJ)
                D9QKEPZRR69LJ = false;
            else if (D9QKEPZRR69LJ = true)
                D9QKEPZRR69LJ = false;
            else
                D9QKEPZRR69LJ = false;
            int D8QOXY6DMK46E = 251367150;
            if (D8QOXY6DMK46E > 251367181)
                D8QOXY6DMK46E = 251367166;
            else if (D8QOXY6DMK46E <= 251367102)
                D8QOXY6DMK46E++;
            else
                D8QOXY6DMK46E = (251367165 / 251367155);
            int DXCAEZSGJY52L = 251367176;
            if (DXCAEZSGJY52L > 251367115)
                DXCAEZSGJY52L = 251367102;
            else if (DXCAEZSGJY52L <= 251367115)
                DXCAEZSGJY52L++;
            else
                DXCAEZSGJY52L = (251367114 / 251367124);
            bool DSP2L0A6XG2L8 = false;
            if (!DSP2L0A6XG2L8)
                DSP2L0A6XG2L8 = true;
            else if (DSP2L0A6XG2L8 = true)
                DSP2L0A6XG2L8 = true;
            else
                DSP2L0A6XG2L8 = true;
            bool DINXPEB7MNZC2 = false;
            if (!DINXPEB7MNZC2)
                DINXPEB7MNZC2 = true;
            else if (DINXPEB7MNZC2 = true)
                DINXPEB7MNZC2 = true;
            else
                DINXPEB7MNZC2 = true;
            int DNB7J4SS49FG5 = 251367119;
            if (DNB7J4SS49FG5 > 251367127)
                DNB7J4SS49FG5 = 251367115;
            else if (DNB7J4SS49FG5 <= 251367177)
                DNB7J4SS49FG5++;
            else
                DNB7J4SS49FG5 = (251367148 / 251367168);
            bool DWEZ2EE2FWSWL = false;
            if (!DWEZ2EE2FWSWL)
                DWEZ2EE2FWSWL = false;
            else if (DWEZ2EE2FWSWL = true)
                DWEZ2EE2FWSWL = false;
            else
                DWEZ2EE2FWSWL = false;
            bool DY0I90QRZJFAF = false;
            if (!DY0I90QRZJFAF)
                DY0I90QRZJFAF = false;
            else if (DY0I90QRZJFAF = false)
                DY0I90QRZJFAF = false;
            else
                DY0I90QRZJFAF = true;
            int DB6X3KFQ75HA1 = 251367173;
            if (DB6X3KFQ75HA1 > 251367187)
                DB6X3KFQ75HA1 = 251367116;
            else if (DB6X3KFQ75HA1 <= 251367142)
                DB6X3KFQ75HA1++;
            else
                DB6X3KFQ75HA1 = (251367118 / 251367151);
            int DQEP5CSOX35XS = 251367131;
            if (DQEP5CSOX35XS > 251367182)
                DQEP5CSOX35XS = 251367101;
            else if (DQEP5CSOX35XS <= 251367139)
                DQEP5CSOX35XS++;
            else
                DQEP5CSOX35XS = (251367156 / 251367132);
            int DD3GHZK851O3L = 251367100;
            if (DD3GHZK851O3L > 251367105)
                DD3GHZK851O3L = 251367135;
            else if (DD3GHZK851O3L <= 251367171)
                DD3GHZK851O3L++;
            else
                DD3GHZK851O3L = (251367114 / 251367163);
            bool DLM7OXJ0XBJBE = false;
            if (!DLM7OXJ0XBJBE)
                DLM7OXJ0XBJBE = true;
            else if (DLM7OXJ0XBJBE = true)
                DLM7OXJ0XBJBE = false;
            else
                DLM7OXJ0XBJBE = true;
            int D06L4QNADFYXN = 251367123;
            if (D06L4QNADFYXN > 251367133)
                D06L4QNADFYXN = 251367137;
            else if (D06L4QNADFYXN <= 251367166)
                D06L4QNADFYXN++;
            else
                D06L4QNADFYXN = (251367141 / 251367150);
        }
        void L9I51ORB123YODP()
        {
            int DEL5DXS86YO8K = 251367140;
            if (DEL5DXS86YO8K > 251367198)
                DEL5DXS86YO8K = 251367144;
            else if (DEL5DXS86YO8K <= 251367136)
                DEL5DXS86YO8K++;
            else
                DEL5DXS86YO8K = (251367114 / 251367194);
            bool D5QGSACJMAHA4 = true;
            if (!D5QGSACJMAHA4)
                D5QGSACJMAHA4 = false;
            else if (D5QGSACJMAHA4 = false)
                D5QGSACJMAHA4 = true;
            else
                D5QGSACJMAHA4 = false;
            int D7LBYEGDBHJ4B = 251367142;
            if (D7LBYEGDBHJ4B > 251367173)
                D7LBYEGDBHJ4B = 251367150;
            else if (D7LBYEGDBHJ4B <= 251367173)
                D7LBYEGDBHJ4B++;
            else
                D7LBYEGDBHJ4B = (251367187 / 251367156);
            int DQGN16EZD3MQY = 251367194;
            if (DQGN16EZD3MQY > 251367138)
                DQGN16EZD3MQY = 251367162;
            else if (DQGN16EZD3MQY <= 251367182)
                DQGN16EZD3MQY++;
            else
                DQGN16EZD3MQY = (251367134 / 251367128);
            int D3CZQOC9P8NPK = 251367165;
            if (D3CZQOC9P8NPK > 251367109)
                D3CZQOC9P8NPK = 251367190;
            else if (D3CZQOC9P8NPK <= 251367175)
                D3CZQOC9P8NPK++;
            else
                D3CZQOC9P8NPK = (251367163 / 251367191);
            int D16LA0Z54X6FL = 251367174;
            if (D16LA0Z54X6FL > 251367156)
                D16LA0Z54X6FL = 251367179;
            else if (D16LA0Z54X6FL <= 251367105)
                D16LA0Z54X6FL++;
            else
                D16LA0Z54X6FL = (251367168 / 251367102);
            bool DM2FON2AH6F5N = true;
            if (!DM2FON2AH6F5N)
                DM2FON2AH6F5N = true;
            else if (DM2FON2AH6F5N = false)
                DM2FON2AH6F5N = true;
            else
                DM2FON2AH6F5N = false;
            int D04C4J144P3AP = 251367137;
            if (D04C4J144P3AP > 251367189)
                D04C4J144P3AP = 251367129;
            else if (D04C4J144P3AP <= 251367126)
                D04C4J144P3AP++;
            else
                D04C4J144P3AP = (251367104 / 251367156);
            int DZO39ZZ7R4JY3 = 251367112;
            if (DZO39ZZ7R4JY3 > 251367112)
                DZO39ZZ7R4JY3 = 251367118;
            else if (DZO39ZZ7R4JY3 <= 251367194)
                DZO39ZZ7R4JY3++;
            else
                DZO39ZZ7R4JY3 = (251367166 / 251367186);
            bool DSC2A43D1N0ES = true;
            if (!DSC2A43D1N0ES)
                DSC2A43D1N0ES = false;
            else if (DSC2A43D1N0ES = false)
                DSC2A43D1N0ES = true;
            else
                DSC2A43D1N0ES = false;
            bool D3DWLRPQCXO9C = false;
            if (!D3DWLRPQCXO9C)
                D3DWLRPQCXO9C = false;
            else if (D3DWLRPQCXO9C = false)
                D3DWLRPQCXO9C = true;
            else
                D3DWLRPQCXO9C = true;
            bool DDKCJ4P531721 = false;
            if (!DDKCJ4P531721)
                DDKCJ4P531721 = true;
            else if (DDKCJ4P531721 = true)
                DDKCJ4P531721 = false;
            else
                DDKCJ4P531721 = true;
            int DA16F552R21IS = 251367103;
            if (DA16F552R21IS > 251367169)
                DA16F552R21IS = 251367132;
            else if (DA16F552R21IS <= 251367102)
                DA16F552R21IS++;
            else
                DA16F552R21IS = (251367176 / 251367146);
            int DE3RJ7SSJB6AD = 251367122;
            if (DE3RJ7SSJB6AD > 251367148)
                DE3RJ7SSJB6AD = 251367178;
            else if (DE3RJ7SSJB6AD <= 251367116)
                DE3RJ7SSJB6AD++;
            else
                DE3RJ7SSJB6AD = (251367157 / 251367187);
            int DQSHSHW8L3W66 = 251367166;
            if (DQSHSHW8L3W66 > 251367114)
                DQSHSHW8L3W66 = 251367163;
            else if (DQSHSHW8L3W66 <= 251367101)
                DQSHSHW8L3W66++;
            else
                DQSHSHW8L3W66 = (251367121 / 251367146);
            bool DI1J3J4B9OIS5 = false;
            if (!DI1J3J4B9OIS5)
                DI1J3J4B9OIS5 = true;
            else if (DI1J3J4B9OIS5 = false)
                DI1J3J4B9OIS5 = true;
            else
                DI1J3J4B9OIS5 = true;
            bool DE82MO1HXBQ0Z = false;
            if (!DE82MO1HXBQ0Z)
                DE82MO1HXBQ0Z = true;
            else if (DE82MO1HXBQ0Z = true)
                DE82MO1HXBQ0Z = true;
            else
                DE82MO1HXBQ0Z = true;
            int DG2KN0RA64HBH = 251367156;
            if (DG2KN0RA64HBH > 251367176)
                DG2KN0RA64HBH = 251367145;
            else if (DG2KN0RA64HBH <= 251367179)
                DG2KN0RA64HBH++;
            else
                DG2KN0RA64HBH = (251367195 / 251367155);
            bool DZPS255W6DY7E = true;
            if (!DZPS255W6DY7E)
                DZPS255W6DY7E = true;
            else if (DZPS255W6DY7E = false)
                DZPS255W6DY7E = true;
            else
                DZPS255W6DY7E = true;
            bool D9QKEPZRR69LJ = true;
            if (!D9QKEPZRR69LJ)
                D9QKEPZRR69LJ = false;
            else if (D9QKEPZRR69LJ = true)
                D9QKEPZRR69LJ = false;
            else
                D9QKEPZRR69LJ = false;
            int D8QOXY6DMK46E = 251367150;
            if (D8QOXY6DMK46E > 251367181)
                D8QOXY6DMK46E = 251367166;
            else if (D8QOXY6DMK46E <= 251367102)
                D8QOXY6DMK46E++;
            else
                D8QOXY6DMK46E = (251367165 / 251367155);
            int DXCAEZSGJY52L = 251367176;
            if (DXCAEZSGJY52L > 251367115)
                DXCAEZSGJY52L = 251367102;
            else if (DXCAEZSGJY52L <= 251367115)
                DXCAEZSGJY52L++;
            else
                DXCAEZSGJY52L = (251367114 / 251367124);
            bool DSP2L0A6XG2L8 = false;
            if (!DSP2L0A6XG2L8)
                DSP2L0A6XG2L8 = true;
            else if (DSP2L0A6XG2L8 = true)
                DSP2L0A6XG2L8 = true;
            else
                DSP2L0A6XG2L8 = true;
            bool DINXPEB7MNZC2 = false;
            if (!DINXPEB7MNZC2)
                DINXPEB7MNZC2 = true;
            else if (DINXPEB7MNZC2 = true)
                DINXPEB7MNZC2 = true;
            else
                DINXPEB7MNZC2 = true;
            int DNB7J4SS49FG5 = 251367119;
            if (DNB7J4SS49FG5 > 251367127)
                DNB7J4SS49FG5 = 251367115;
            else if (DNB7J4SS49FG5 <= 251367177)
                DNB7J4SS49FG5++;
            else
                DNB7J4SS49FG5 = (251367148 / 251367168);
            bool DWEZ2EE2FWSWL = false;
            if (!DWEZ2EE2FWSWL)
                DWEZ2EE2FWSWL = false;
            else if (DWEZ2EE2FWSWL = true)
                DWEZ2EE2FWSWL = false;
            else
                DWEZ2EE2FWSWL = false;
            bool DY0I90QRZJFAF = false;
            if (!DY0I90QRZJFAF)
                DY0I90QRZJFAF = false;
            else if (DY0I90QRZJFAF = false)
                DY0I90QRZJFAF = false;
            else
                DY0I90QRZJFAF = true;
            int DB6X3KFQ75HA1 = 251367173;
            if (DB6X3KFQ75HA1 > 251367187)
                DB6X3KFQ75HA1 = 251367116;
            else if (DB6X3KFQ75HA1 <= 251367142)
                DB6X3KFQ75HA1++;
            else
                DB6X3KFQ75HA1 = (251367118 / 251367151);
            int DQEP5CSOX35XS = 251367131;
            if (DQEP5CSOX35XS > 251367182)
                DQEP5CSOX35XS = 251367101;
            else if (DQEP5CSOX35XS <= 251367139)
                DQEP5CSOX35XS++;
            else
                DQEP5CSOX35XS = (251367156 / 251367132);
            int DD3GHZK851O3L = 251367100;
            if (DD3GHZK851O3L > 251367105)
                DD3GHZK851O3L = 251367135;
            else if (DD3GHZK851O3L <= 251367171)
                DD3GHZK851O3L++;
            else
                DD3GHZK851O3L = (251367114 / 251367163);
            bool DLM7OXJ0XBJBE = false;
            if (!DLM7OXJ0XBJBE)
                DLM7OXJ0XBJBE = true;
            else if (DLM7OXJ0XBJBE = true)
                DLM7OXJ0XBJBE = false;
            else
                DLM7OXJ0XBJBE = true;
            int D06L4QNADFYXN = 251367123;
            if (D06L4QNADFYXN > 251367133)
                D06L4QNADFYXN = 251367137;
            else if (D06L4QNADFYXN <= 251367166)
                D06L4QNADFYXN++;
            else
                D06L4QNADFYXN = (251367141 / 251367150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?  CS:GO'da kapatılacak.", "MeowPremium by yukselexe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {

                
                string islemadi = "csgo"; 
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    if (process.ProcessName == islemadi)
                    {
                        process.Kill();
                        

                    }

                }
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fovTrack_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Fov: " + Convert.ToString(fovTrack.Value);
        }

        private void fSetBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 99999; i++)
            {
                int LocalBase = yuksel.ReadInt32((IntPtr)clientModule.moduleAdress + Pointer_Offset_List.LocalPlayer);
                yuksel.WriteInt32((IntPtr)LocalBase + 0x31E4, fovTrack.Value);
                i++;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://justpaste.it/5i4di");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ESPCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BunnyhopCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
