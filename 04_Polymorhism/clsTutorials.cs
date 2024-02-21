using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polymorhism
{
    internal class clsTutorials
    {
        protected int TutorialID { get; set; }
        protected string TutorialName { get; set;}
        protected string TutorialDescription { get; set;}

        // 1.Hal
        public void setTutorial(int pID,string pTutorialName)
        {
            TutorialID = pID;
            TutorialName = pTutorialName;
        }

        // 2.Hal
        public void setTutorial(string pTutorialName)
        {
            TutorialName = pTutorialName;
        }

        // 3.Hal
        public void setTutorial(int pID, string pTutorialName,string pDesc)
        {
            TutorialID = pID;
            TutorialName = pTutorialName;
            TutorialDescription = pDesc;
        }

        public string getTutorial()
        {
            return TutorialID + " " + TutorialName + " " + TutorialDescription;
        }

    }
}
