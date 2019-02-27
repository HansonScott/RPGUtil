using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RPGUtil.RPGObjects;

namespace RPGUtil
{
    public partial class Form1 : Form
    {
        public static Form1 CurrentForm;

        public Form1()
        {
            CurrentForm = this;
            InitializeComponent();
            PopulateControls();
        }

        private void PopulateControls()
        {
            cbClasses.DataSource = Enum.GetNames(typeof(RPGObjects.Classes));

            cbConflict.DataSource = Enum.GetNames(typeof(QuestObjects.Conflicts));
            cbQuantity.DataSource = Enum.GetNames(typeof(QuestObjects.Quantities));
            cbAntagonists.DataSource = Enum.GetNames(typeof(QuestObjects.Antagonists));
        }

        #region Dice Roll Tab

        #region Event Buttons
        private void btnD4_Click(object sender, EventArgs e)
        {
            Roller.Roll(1, 4);
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            Roller.Roll(1, 6);
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            Roller.Roll(1, 8);
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            Roller.Roll(1, 10);
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            Roller.Roll(1, 12);
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            Roller.Roll(1, 20);
        }

        private void btnDxDy_Click(object sender, EventArgs e)
        {
            Roller.Roll((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void btnAbilities_Click(object sender, EventArgs e)
        {
            Roller.RollAbility();
        }

        private void btnAbilitiesX6_Click(object sender, EventArgs e)
        {
            Output("----");
            Roller.RollAbility();
            Roller.RollAbility();
            Roller.RollAbility();
            Roller.RollAbility();
            Roller.RollAbility();
            Roller.RollAbility();
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            Output("-- Blank Character --");
            this.nud_Str.Value = Roller.RollAbility();
            this.nud_Dex.Value = Roller.RollAbility();
            this.nud_Con.Value = Roller.RollAbility();
            this.nud_Int.Value = Roller.RollAbility();
            this.nud_Wis.Value = Roller.RollAbility();
            this.nud_Cha.Value = Roller.RollAbility();
        }
        private void nud_Str_ValueChanged(object sender, EventArgs e)
        {
            SetAbilityBonus((int)nud_Str.Value, lblStrBonus);
        }

        private void nud_Dex_ValueChanged(object sender, EventArgs e)
        {
            SetAbilityBonus((int)nud_Dex.Value, lblDexBonus);
        }

        private void nud_Con_ValueChanged(object sender, EventArgs e)
        {
            SetAbilityBonus((int)nud_Con.Value, lblConBonus);
        }

        private void nud_Int_ValueChanged(object sender, EventArgs e)
        {
            SetAbilityBonus((int)nud_Int.Value, lblIntBonus);
        }

        private void nud_Wis_ValueChanged(object sender, EventArgs e)
        {
            SetAbilityBonus((int)nud_Wis.Value, lblWisBonus);
        }

        private void nud_Cha_ValueChanged(object sender, EventArgs e)
        {
            SetAbilityBonus((int)nud_Cha.Value, lblChaBonus);
        }

        private void btnRandChar_Click(object sender, EventArgs e)
        {
            GenerateRandomChar((int)Enum.Parse(typeof(Classes), cbClasses.Text));
        }
        #endregion

        private void SetAbilityBonus(int abilityVal, Label lblBonus)
        {
            int bonusVal = (abilityVal - 10) / 2;

            Color bonusColor = Color.Black;
            string lblVal = "";
            if(bonusVal > 0)
            {
                bonusColor = Color.DarkGreen;
                lblVal = "+";
            }
            else if(bonusVal < 0)
            {
                bonusColor = Color.Red;
                lblVal = "-";
            }
            else
            {
                bonusColor = Color.Black;
            }

            lblVal += "" + bonusVal;

            lblBonus.ForeColor = bonusColor;
            lblBonus.Text = lblVal;
        }

        private void GenerateRandomChar(int RPGClass)
        {
            string className = "-- " + Enum.GetName(typeof(Classes), RPGClass) + " --";
            Output(className);
            int[] AbilityPriority = new int[Enum.GetNames(typeof(Abilities)).Length];
            switch(RPGClass)
            {
                case (int)Classes.Barbarian:
                    AbilityPriority = new int[] {
                        (int)Abilities.Strength,
                        (int)Abilities.Constitution,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Wisdom,
                        (int)Abilities.Charisma,
                        (int)Abilities.Intelligence,
                    };
                    break;
                case (int)Classes.Bard:
                    AbilityPriority = new int[] {
                        (int)Abilities.Charisma,
                        (int)Abilities.Intelligence,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Constitution,
                        (int)Abilities.Strength,
                        (int)Abilities.Wisdom,
                    };
                    break;
                case (int)Classes.Cleric:
                    AbilityPriority = new int[] {
                        (int)Abilities.Wisdom,
                        (int)Abilities.Constitution,
                        (int)Abilities.Strength,
                        (int)Abilities.Charisma,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Intelligence,
                    };
                    break;
                case (int)Classes.Druid:
                    AbilityPriority = new int[] {
                        (int)Abilities.Wisdom,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Intelligence,
                        (int)Abilities.Charisma,
                        (int)Abilities.Constitution,
                        (int)Abilities.Strength,
                    };
                    break;
                case (int)Classes.Fighter:
                    AbilityPriority = new int[] {
                        (int)Abilities.Strength,
                        (int)Abilities.Constitution,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Charisma,
                        (int)Abilities.Wisdom,
                        (int)Abilities.Intelligence,
                    };
                    break;
                case (int)Classes.Paladin:
                    AbilityPriority = new int[] {
                        (int)Abilities.Strength,
                        (int)Abilities.Wisdom,
                        (int)Abilities.Charisma,
                        (int)Abilities.Constitution,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Intelligence,
                    };
                    break;
                case (int)Classes.Rogue:
                    AbilityPriority = new int[] {
                        (int)Abilities.Dexterity,
                        (int)Abilities.Intelligence,
                        (int)Abilities.Charisma,
                        (int)Abilities.Strength,
                        (int)Abilities.Constitution,
                        (int)Abilities.Wisdom,
                    };
                    break;
                case (int)Classes.Warlock:
                    AbilityPriority = new int[] {
                        (int)Abilities.Charisma,
                        (int)Abilities.Constitution,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Strength,
                        (int)Abilities.Intelligence,
                        (int)Abilities.Wisdom,
                    };
                    break;
                case (int)Classes.Wizard:
                    AbilityPriority = new int[] {
                        (int)Abilities.Intelligence,
                        (int)Abilities.Charisma,
                        (int)Abilities.Dexterity,
                        (int)Abilities.Constitution,
                        (int)Abilities.Wisdom,
                        (int)Abilities.Strength,
                    };
                    break;
                default:
                    MessageBox.Show("Class unrecognized, cannot create random character.");
                    break;
            }

            List<int> abs = new List<int>();
            for(int i = 0; i < Enum.GetValues(typeof(Abilities)).Length; i++)
            {
                abs.Add(Roller.RollAbility(true));
            }

            abs.Sort();

            int[] results = new int[6];

            int current = 5;
            foreach(int AP in AbilityPriority)
            {
                results[AP] = abs[current--];
            }

            SetCharacterAbilities(results);
        }

        private void SetCharacterAbilities(int[] vals)
        {
            nud_Str.Value = vals[0];
            nud_Dex.Value = vals[1];
            nud_Con.Value = vals[2];
            nud_Int.Value = vals[3];
            nud_Wis.Value = vals[4];
            nud_Cha.Value = vals[5];
        }
        #endregion

        #region Quests
        private void btnQuestDisplay_Click(object sender, EventArgs e)
        {
            Output("-- Quest --");
            QuestObjects.Antagonists a = (QuestObjects.Antagonists)Enum.Parse(typeof(QuestObjects.Antagonists), cbAntagonists.SelectedValue.ToString());
            QuestObjects.Quantities q = (QuestObjects.Quantities)Enum.Parse(typeof(QuestObjects.Quantities), cbQuantity.SelectedValue.ToString());
            string who = QuestObjects.GetDisplayForQuantityOfAntagonists(a, q);
            Output(who);
        }

        private void btnRandomRequest_Click(object sender, EventArgs e)
        {
            string who = GetRandomQuantityAndAntagonists();
            Output("-- Antagonist(s) --");
            Output(who);
        }

        private string GetRandomQuantityAndAntagonists()
        {
            int ia = Roller.RandomEnum(typeof(QuestObjects.Antagonists));
            QuestObjects.Antagonists a = (QuestObjects.Antagonists)Enum.Parse(typeof(QuestObjects.Antagonists), ia.ToString());
            int iq = Roller.RandomEnum(typeof(QuestObjects.Quantities));
            QuestObjects.Quantities q = (QuestObjects.Quantities)Enum.Parse(typeof(QuestObjects.Quantities), iq.ToString());

            string who = QuestObjects.GetDisplayForQuantityOfAntagonists(a, q);
            return who;
        }

        private void btnConflict_Click(object sender, EventArgs e)
        {
            Output("Conflict: " + cbConflict.Text);
        }

        private void btnConflictRandom_Click(object sender, EventArgs e)
        {
            string s = GetRandomConflict();
            Output("-- Conflict --");
            Output(s);
        }

        private string GetRandomConflict()
        {
            int ic = Roller.RandomEnum(typeof(QuestObjects.Conflicts));
            QuestObjects.Conflicts c = (QuestObjects.Conflicts)Enum.Parse(typeof(QuestObjects.Conflicts), ic.ToString());
            string s = QuestObjects.GetDisplayForConflict(c);
            return s;
        }

        private void btnRandomQuest_Click(object sender, EventArgs e)
        {
            Output("-- Quest --");
            string what = GetRandomConflict();
            string who = GetRandomQuantityAndAntagonists();
            Output($"{what} involving {who}");
        }
        #endregion
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbOutput.Text = String.Empty;
        }
        public void Output(string msg)
        {
            if (tbOutput.Text.Length > 0)
            {
                tbOutput.AppendText(Environment.NewLine);
            }
            tbOutput.AppendText(msg);
        }

    }
}
