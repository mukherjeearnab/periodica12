using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodica_v12o1
{
    public partial class Table : MetroFramework.Forms.MetroForm
    {
        bool appMode;
        public Table(bool AM)
        {
            InitializeComponent();
            appMode = AM;
            toolTipInitilise();
        }

        public void toolTipInitilise()
        {
            metroToolTip1 = new MetroFramework.Components.MetroToolTip();

            metroToolTip1.SetToolTip(this.metroTile1, "Hydrogen\nAtomic No. - 1");
            metroToolTip1.SetToolTip(this.metroTile2, "Helium \nAtomic No. - 2");
            metroToolTip1.SetToolTip(this.metroTile3, "Lithium \nAtomic No. - 3");
            metroToolTip1.SetToolTip(this.metroTile4, "Beryllium \nAtomic No. - 4");
            metroToolTip1.SetToolTip(this.metroTile6, "Sodium \nAtomic No. - 11");
            metroToolTip1.SetToolTip(this.metroTile5, "Magnesium \nAtomic No. - 12");
            metroToolTip1.SetToolTip(this.metroTile8, "Pottasium \nAtomic No. - 19");
            metroToolTip1.SetToolTip(this.metroTile7, "Calcium \nAtomic No. - 20");
            metroToolTip1.SetToolTip(this.metroTile10, "Rubidium \nAtomic No. - 37");
            metroToolTip1.SetToolTip(this.metroTile9, "Strontium \nAtomic No. - 38");
            metroToolTip1.SetToolTip(this.metroTile12, "Cesium \nAtomic No. - 55");
            metroToolTip1.SetToolTip(this.metroTile11, "Barium \nAtomic No. - 56");
            metroToolTip1.SetToolTip(this.metroTile14, "Francium \nAtomic No. - 87");
            metroToolTip1.SetToolTip(this.metroTile13, "Radium \nAtomic No. - 88");
            metroToolTip1.SetToolTip(this.metroTile70, "Scandium \nAtomic No. - 21");
            metroToolTip1.SetToolTip(this.metroTile69, "Titanium \nAtomic No. - 22");
            metroToolTip1.SetToolTip(this.metroTile80, "Yttrium \nAtomic No. - 39");
            metroToolTip1.SetToolTip(this.metroTile79, "Zirconium \nAtomic No. - 40");
            metroToolTip1.SetToolTip(this.metroTile89, "Hafnium \nAtomic No. - 72");
            metroToolTip1.SetToolTip(this.metroTile99, "Rutherfordium \nAtomic No. - 104");
            metroToolTip1.SetToolTip(this.metroTile68, "Vanadium \nAtomic No. - 23");
            metroToolTip1.SetToolTip(this.metroTile67, "Chromium \nAtomic No. - 24");
            metroToolTip1.SetToolTip(this.metroTile78, "Niobium \nAtomic No. - 41");
            metroToolTip1.SetToolTip(this.metroTile77, "Molybdenum \nAtomic No. - 42");
            metroToolTip1.SetToolTip(this.metroTile88, "Tantalum \nAtomic No. - 73");
            metroToolTip1.SetToolTip(this.metroTile87, "Tungsten \nAtomic No. - 74");
            metroToolTip1.SetToolTip(this.metroTile98, "Dubnium \nAtomic No. - 105");
            metroToolTip1.SetToolTip(this.metroTile97, "Seaborgium \nAtomic No. - 106");
            metroToolTip1.SetToolTip(this.metroTile66, "Manganese \nAtomic No. - 25");
            metroToolTip1.SetToolTip(this.metroTile65, "Iron \nAtomic No. - 26");
            metroToolTip1.SetToolTip(this.metroTile76, "Technetuim \nAtomic No. - 43");
            metroToolTip1.SetToolTip(this.metroTile75, "Ruthenuim \nAtomic No. - 44");
            metroToolTip1.SetToolTip(this.metroTile86, "Rhenuim \nAtomic No. - 75");
            metroToolTip1.SetToolTip(this.metroTile85, "Osmium \nAtomic No. - 76");
            metroToolTip1.SetToolTip(this.metroTile96, "Bohrium \nAtomic No. - 107");
            metroToolTip1.SetToolTip(this.metroTile95, "Hassium \nAtomic No. - 108");
            metroToolTip1.SetToolTip(this.metroTile64, "Cobalt \nAtomic No. - 27");
            metroToolTip1.SetToolTip(this.metroTile63, "Nickel \nAtomic No. - 28");
            metroToolTip1.SetToolTip(this.metroTile74, "Rhodium \nAtomic No. - 45");
            metroToolTip1.SetToolTip(this.metroTile73, "Palladium \nAtomic No. - 46");
            metroToolTip1.SetToolTip(this.metroTile84, "Iridium \nAtomic No. - 77");
            metroToolTip1.SetToolTip(this.metroTile83, "Platinum \nAtomic No. - 78");
            metroToolTip1.SetToolTip(this.metroTile94, "Meitnerium \nAtomic No. - 109");
            metroToolTip1.SetToolTip(this.metroTile93, "Darmstadium \nAtomic No. - 110");
            metroToolTip1.SetToolTip(this.metroTile62, "Copper \nAtomic No. - 27");
            metroToolTip1.SetToolTip(this.metroTile61, "Zinc \nAtomic No. - 28");
            metroToolTip1.SetToolTip(this.metroTile72, "Silver \nAtomic No. - 47");
            metroToolTip1.SetToolTip(this.metroTile71, "Cadmium \nAtomic No. - 48");
            metroToolTip1.SetToolTip(this.metroTile82, "Gold \nAtomic No. - 79");
            metroToolTip1.SetToolTip(this.metroTile81, "Mercury \nAtomic No. - 80");
            metroToolTip1.SetToolTip(this.metroTile92, "Roentgenium \nAtomic No. - 111");
            metroToolTip1.SetToolTip(this.metroTile91, "Copernicium \nAtomic No. - 112");
            metroToolTip1.SetToolTip(this.metroTile16, "Boron \nAtomic No. - 5");
            metroToolTip1.SetToolTip(this.metroTile15, "Carbon \nAtomic No. - 6");
            metroToolTip1.SetToolTip(this.metroTile18, "Nitrogen \nAtomic No. - 7");
            metroToolTip1.SetToolTip(this.metroTile26, "Aluminium \nAtomic No. - 13");
            metroToolTip1.SetToolTip(this.metroTile25, "Silicon \nAtomic No. - 14");
            metroToolTip1.SetToolTip(this.metroTile24, "Phosphorous \nAtomic No. - 15");
            metroToolTip1.SetToolTip(this.metroTile32, "Gallium \nAtomic No. - 31");
            metroToolTip1.SetToolTip(this.metroTile31, "Germanium \nAtomic No. - 32");
            metroToolTip1.SetToolTip(this.metroTile30, "Arsenic \nAtomic No. - 33");
            metroToolTip1.SetToolTip(this.metroTile38, "Indium \nAtomic No. - 49");
            metroToolTip1.SetToolTip(this.metroTile37, "Tin \nAtomic No. - 50");
            metroToolTip1.SetToolTip(this.metroTile36, "Antimony \nAtomic No. - 51");
            metroToolTip1.SetToolTip(this.metroTile44, "Thallium \nAtomic No. - 81");
            metroToolTip1.SetToolTip(this.metroTile43, "Lead \nAtomic No. - 82");
            metroToolTip1.SetToolTip(this.metroTile42, "Bismuth \nAtomic No. - 83");
            metroToolTip1.SetToolTip(this.metroTile50, "Ununtrium \nAtomic No. - 113");
            metroToolTip1.SetToolTip(this.metroTile49, "Ununquadium \nAtomic No. - 114");
            metroToolTip1.SetToolTip(this.metroTile48, "Ununpentium \nAtomic No. - 115");
            metroToolTip1.SetToolTip(this.metroTile17, "Oxygen \nAtomic No. - 8");
            metroToolTip1.SetToolTip(this.metroTile20, "Florine \nAtomic No. - 9");
            metroToolTip1.SetToolTip(this.metroTile19, "Neon \nAtomic No. - 10");
            metroToolTip1.SetToolTip(this.metroTile23, "Sulphur \nAtomic No. - 16");
            metroToolTip1.SetToolTip(this.metroTile22, "Chlorine \nAtomic No. - 17");
            metroToolTip1.SetToolTip(this.metroTile21, "Argon \nAtomic No. - 18");
            metroToolTip1.SetToolTip(this.metroTile29, "Selenium \nAtomic No. - 34");
            metroToolTip1.SetToolTip(this.metroTile28, "Bromine \nAtomic No. - 35");
            metroToolTip1.SetToolTip(this.metroTile27, "Krypton \nAtomic No. - 36");
            metroToolTip1.SetToolTip(this.metroTile35, "Tellurium \nAtomic No. - 52");
            metroToolTip1.SetToolTip(this.metroTile34, "Iodine \nAtomic No. - 53");
            metroToolTip1.SetToolTip(this.metroTile33, "Xenon \nAtomic No. - 54");
            metroToolTip1.SetToolTip(this.metroTile41, "Polonium \nAtomic No. - 84");
            metroToolTip1.SetToolTip(this.metroTile40, "Astatine \nAtomic No. - 85");
            metroToolTip1.SetToolTip(this.metroTile39, "Radon \nAtomic No. - 86");
            metroToolTip1.SetToolTip(this.metroTile47, "Ununhexium \nAtomic No. - 116");
            metroToolTip1.SetToolTip(this.metroTile46, "Ununseptuim \nAtomic No. - 117");
            metroToolTip1.SetToolTip(this.metroTile45, "Ununoctium \nAtomic No. - 118");
            metroToolTip1.SetToolTip(this.metroTile107, "Lanthanum \nAtomic No. - 57");
            metroToolTip1.SetToolTip(this.metroTile106, "Cerium \nAtomic No. - 58");
            metroToolTip1.SetToolTip(this.metroTile121, "Actinium \nAtomic No. - 89");
            metroToolTip1.SetToolTip(this.metroTile120, "Thorium \nAtomic No. - 90");
            metroToolTip1.SetToolTip(this.metroTile105, "Praseodium \nAtomic No. - 59");
            metroToolTip1.SetToolTip(this.metroTile104, "Neodymium \nAtomic No. - 60");
            metroToolTip1.SetToolTip(this.metroTile119, "Protactium \nAtomic No. - 91");
            metroToolTip1.SetToolTip(this.metroTile118, "Uranium \nAtomic No. - 92");
            metroToolTip1.SetToolTip(this.metroTile103, "Promethium \nAtomic No. - 61");
            metroToolTip1.SetToolTip(this.metroTile102, "Samarium \nAtomic No. - 62");
            metroToolTip1.SetToolTip(this.metroTile117, "Neptunium \nAtomic No. - 93");
            metroToolTip1.SetToolTip(this.metroTile116, "Plutonium \nAtomic No. - 94");
            metroToolTip1.SetToolTip(this.metroTile101, "Europium \nAtomic No. - 63");
            metroToolTip1.SetToolTip(this.metroTile100, "Gadolinium \nAtomic No. - 64");
            metroToolTip1.SetToolTip(this.metroTile115, "Americium \nAtomic No. - 95");
            metroToolTip1.SetToolTip(this.metroTile114, "Curium \nAtomic No. - 96");
            metroToolTip1.SetToolTip(this.metroTile90, "Terbium \nAtomic No. - 65");
            metroToolTip1.SetToolTip(this.metroTile112, "Dysprosium \nAtomic No. - 66");
            metroToolTip1.SetToolTip(this.metroTile113, "Berkelium \nAtomic No. - 97");
            metroToolTip1.SetToolTip(this.metroTile126, "Californium \nAtomic No. - 98");
            metroToolTip1.SetToolTip(this.metroTile111, "Holmium \nAtomic No. - 67");
            metroToolTip1.SetToolTip(this.metroTile110, "Erbium \nAtomic No. - 68");
            metroToolTip1.SetToolTip(this.metroTile125, "Einstienium \nAtomic No. - 99");
            metroToolTip1.SetToolTip(this.metroTile124, "Fermium \nAtomic No. - 100");
            metroToolTip1.SetToolTip(this.metroTile109, "Thulium \nAtomic No. - 69");
            metroToolTip1.SetToolTip(this.metroTile108, "Ytterbium \nAtomic No. - 70");
            metroToolTip1.SetToolTip(this.metroTile123, "Mendelevium \nAtomic No. - 101");
            metroToolTip1.SetToolTip(this.metroTile122, "Nobelium \nAtomic No. - 102");
            metroToolTip1.SetToolTip(this.metroTile52, "Lutetium \nAtomic No. - 71");
            metroToolTip1.SetToolTip(this.metroTile51, "Lawrencium \nAtomic No. - 103");
        }

        public void onElementClick(int atm)
        {
            OfflineDispay o = new OfflineDispay(atm, appMode);
            o.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            onElementClick(3);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            onElementClick(1);
        }

        private void metroTile53_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            onElementClick(2);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            onElementClick(4);
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            onElementClick(5);
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            onElementClick(6);
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            onElementClick(7);
        }

        private void metroTile17_Click(object sender, EventArgs e)
        {
            onElementClick(8);
        }

        private void metroTile20_Click(object sender, EventArgs e)
        {
            onElementClick(9);
        }

        private void metroTile19_Click(object sender, EventArgs e)
        {
            onElementClick(10);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            onElementClick(11);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            onElementClick(12);
        }

        private void metroTile26_Click(object sender, EventArgs e)
        {
            onElementClick(13);
        }

        private void metroTile25_Click(object sender, EventArgs e)
        {
            onElementClick(14);
        }

        private void metroTile24_Click(object sender, EventArgs e)
        {
            onElementClick(15);
        }

        private void metroTile23_Click(object sender, EventArgs e)
        {
            onElementClick(16);
        }

        private void metroTile22_Click(object sender, EventArgs e)
        {
            onElementClick(17);
        }

        private void metroTile21_Click(object sender, EventArgs e)
        {
            onElementClick(18);
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            onElementClick(19);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            onElementClick(20);
        }

        private void metroTile70_Click(object sender, EventArgs e)
        {
            onElementClick(21);
        }

        private void metroTile69_Click(object sender, EventArgs e)
        {
            onElementClick(22);
        }

        private void metroTile68_Click(object sender, EventArgs e)
        {
            onElementClick(23);
        }

        private void metroTile67_Click(object sender, EventArgs e)
        {
            onElementClick(24);
        }

        private void metroTile66_Click(object sender, EventArgs e)
        {
            onElementClick(25);
        }

        private void metroTile65_Click(object sender, EventArgs e)
        {
            onElementClick(26);
        }

        private void metroTile64_Click(object sender, EventArgs e)
        {
            onElementClick(27);
        }

        private void metroTile63_Click(object sender, EventArgs e)
        {
            onElementClick(28);
        }

        private void metroTile62_Click(object sender, EventArgs e)
        {
            onElementClick(29);
        }

        private void metroTile61_Click(object sender, EventArgs e)
        {
            onElementClick(30);
        }

        private void metroTile32_Click(object sender, EventArgs e)
        {
            onElementClick(31);
        }

        private void metroTile31_Click(object sender, EventArgs e)
        {
            onElementClick(32);
        }

        private void metroTile30_Click(object sender, EventArgs e)
        {
            onElementClick(33);
        }

        private void metroTile29_Click(object sender, EventArgs e)
        {
            onElementClick(34);
        }

        private void metroTile28_Click(object sender, EventArgs e)
        {
            onElementClick(35);
        }

        private void metroTile27_Click(object sender, EventArgs e)
        {
            onElementClick(36);
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            onElementClick(37);
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            onElementClick(38);
        }

        private void metroTile80_Click(object sender, EventArgs e)
        {
            onElementClick(39);
        }

        private void metroTile79_Click(object sender, EventArgs e)
        {
            onElementClick(40);
        }

        private void metroTile78_Click(object sender, EventArgs e)
        {
            onElementClick(41);
        }

        private void metroTile77_Click(object sender, EventArgs e)
        {
            onElementClick(42);
        }

        private void metroTile76_Click(object sender, EventArgs e)
        {
            onElementClick(43);
        }

        private void metroTile75_Click(object sender, EventArgs e)
        {
            onElementClick(44);
        }

        private void metroTile74_Click(object sender, EventArgs e)
        {
            onElementClick(45);
        }

        private void metroTile73_Click(object sender, EventArgs e)
        {
            onElementClick(46);
        }

        private void metroTile72_Click(object sender, EventArgs e)
        {
            onElementClick(47);
        }

        private void metroTile71_Click(object sender, EventArgs e)
        {
            onElementClick(48);
        }

        private void metroTile38_Click(object sender, EventArgs e)
        {
            onElementClick(49);
        }

        private void metroTile37_Click(object sender, EventArgs e)
        {
            onElementClick(50);
        }

        private void metroTile36_Click(object sender, EventArgs e)
        {
            onElementClick(51);
        }

        private void metroTile35_Click(object sender, EventArgs e)
        {
            onElementClick(52);
        }

        private void metroTile34_Click(object sender, EventArgs e)
        {
            onElementClick(53);
        }

        private void metroTile33_Click(object sender, EventArgs e)
        {
            onElementClick(54);
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            onElementClick(55);
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            onElementClick(56);
        }

        private void metroTile107_Click(object sender, EventArgs e)
        {
            onElementClick(57);
        }

        private void metroTile106_Click(object sender, EventArgs e)
        {
            onElementClick(58);
        }

        private void metroTile105_Click(object sender, EventArgs e)
        {
            onElementClick(59);
        }

        private void metroTile104_Click(object sender, EventArgs e)
        {
            onElementClick(60);
        }

        private void metroTile103_Click(object sender, EventArgs e)
        {
            onElementClick(61);
        }

        private void metroTile102_Click(object sender, EventArgs e)
        {
            onElementClick(62);
        }

        private void metroTile101_Click(object sender, EventArgs e)
        {
            onElementClick(63);
        }

        private void metroTile100_Click(object sender, EventArgs e)
        {
            onElementClick(64);
        }

        private void metroTile90_Click(object sender, EventArgs e)
        {
            onElementClick(65);
        }

        private void metroTile112_Click(object sender, EventArgs e)
        {
            onElementClick(66);
        }

        private void metroTile111_Click(object sender, EventArgs e)
        {
            onElementClick(67);
        }

        private void metroTile110_Click(object sender, EventArgs e)
        {
            onElementClick(68);
        }

        private void metroTile109_Click(object sender, EventArgs e)
        {
            onElementClick(69);
        }

        private void metroTile108_Click(object sender, EventArgs e)
        {
            onElementClick(70);
        }

        private void metroTile52_Click(object sender, EventArgs e)
        {
            onElementClick(71);
        }

        private void metroTile89_Click(object sender, EventArgs e)
        {
            onElementClick(72);
        }

        private void metroTile88_Click(object sender, EventArgs e)
        {
            onElementClick(73);
        }

        private void metroTile87_Click(object sender, EventArgs e)
        {
            onElementClick(74);
        }

        private void metroTile86_Click(object sender, EventArgs e)
        {
            onElementClick(75);
        }

        private void metroTile85_Click(object sender, EventArgs e)
        {
            onElementClick(76);
        }

        private void metroTile84_Click(object sender, EventArgs e)
        {
            onElementClick(77);
        }

        private void metroTile83_Click(object sender, EventArgs e)
        {
            onElementClick(78);
        }

        private void metroTile82_Click(object sender, EventArgs e)
        {
            onElementClick(79);
        }

        private void metroTile81_Click(object sender, EventArgs e)
        {
            onElementClick(80);
        }

        private void metroTile44_Click(object sender, EventArgs e)
        {
            onElementClick(81);
        }

        private void metroTile43_Click(object sender, EventArgs e)
        {
            onElementClick(82);
        }

        private void metroTile42_Click(object sender, EventArgs e)
        {
            onElementClick(83);
        }

        private void metroTile41_Click(object sender, EventArgs e)
        {
            onElementClick(84);
        }

        private void metroTile40_Click(object sender, EventArgs e)
        {
            onElementClick(85);
        }

        private void metroTile39_Click(object sender, EventArgs e)
        {
            onElementClick(86);
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            onElementClick(87);
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            onElementClick(88);
        }

        private void metroTile121_Click(object sender, EventArgs e)
        {
            onElementClick(89);
        }

        private void metroTile120_Click(object sender, EventArgs e)
        {
            onElementClick(90);
        }

        private void metroTile119_Click(object sender, EventArgs e)
        {
            onElementClick(91);
        }

        private void metroTile118_Click(object sender, EventArgs e)
        {
            onElementClick(92);
        }

        private void metroTile117_Click(object sender, EventArgs e)
        {
            onElementClick(93);
        }

        private void metroTile116_Click(object sender, EventArgs e)
        {
            onElementClick(94);
        }

        private void metroTile115_Click(object sender, EventArgs e)
        {
            onElementClick(95);
        }

        private void metroTile114_Click(object sender, EventArgs e)
        {
            onElementClick(96);
        }

        private void metroTile113_Click(object sender, EventArgs e)
        {
            onElementClick(97);
        }

        private void metroTile126_Click(object sender, EventArgs e)
        {
            onElementClick(98);
        }

        private void metroTile125_Click(object sender, EventArgs e)
        {
            onElementClick(99);
        }

        private void metroTile124_Click(object sender, EventArgs e)
        {
            onElementClick(100);
        }

        private void metroTile123_Click(object sender, EventArgs e)
        {
            onElementClick(101);
        }

        private void metroTile122_Click(object sender, EventArgs e)
        {
            onElementClick(102);
        }

        private void metroTile51_Click(object sender, EventArgs e)
        {
            onElementClick(103);
        }

        private void metroTile99_Click(object sender, EventArgs e)
        {
            onElementClick(104);
        }

        private void metroTile98_Click(object sender, EventArgs e)
        {
            onElementClick(105);
        }

        private void metroTile97_Click(object sender, EventArgs e)
        {
            onElementClick(106);
        }

        private void metroTile96_Click(object sender, EventArgs e)
        {
            onElementClick(107);
        }

        private void metroTile95_Click(object sender, EventArgs e)
        {
            onElementClick(108);
        }

        private void metroTile94_Click(object sender, EventArgs e)
        {
            onElementClick(109);
        }

        private void metroTile93_Click(object sender, EventArgs e)
        {
            onElementClick(110);
        }

        private void metroTile92_Click(object sender, EventArgs e)
        {
            onElementClick(111);
        }

        private void metroTile91_Click(object sender, EventArgs e)
        {
            onElementClick(112);
        }

        private void metroTile50_Click(object sender, EventArgs e)
        {
            onElementClick(113);
        }

        private void metroTile49_Click(object sender, EventArgs e)
        {
            onElementClick(114);
        }

        private void metroTile48_Click(object sender, EventArgs e)
        {
            onElementClick(115);
        }

        private void metroTile47_Click(object sender, EventArgs e)
        {
            onElementClick(116);
        }

        private void metroTile46_Click(object sender, EventArgs e)
        {
            onElementClick(117);
        }

        private void metroTile45_Click(object sender, EventArgs e)
        {
            onElementClick(118);
        }

        private void metroTile54_Click(object sender, EventArgs e)
        {
            ColourCodes c = new ColourCodes();
            c.Show();
        }

        private void metroTile55_Click(object sender, EventArgs e)
        {
            Image i = new Image();
            i.Show();
        }
    }
}
