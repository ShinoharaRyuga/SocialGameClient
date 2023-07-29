using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Outgame
{
    public class UIEventHomeView : UIStackableView
    {
        protected override void AwakeCall()
        {
            ViewId = ViewID.Event;
            _hasPopUI = true;
        }

        public override void Enter()
        {
            base.Enter();

            UIStatusBar.Show();

            Debug.Log(EventHelper.GetAllOpenedEvent());
            Debug.Log(EventHelper.IsEventGamePlayable(1));
        }

        public void GoHome()
        {
            UIManager.NextView(ViewID.Home);
        }

        public void GoEventQuest()
        {
            //Debug.Log("�C�x���g�N�G�X�g�Ɉړ�");
            UIManager.NextView(ViewID.EventQuest);
        }

        public void GoRanking()
        {
            Debug.Log("�����L���O�ֈړ�");
            //UIManager.NextView(ViewID.QuestResult);
        }


        public void DialogTest()
        {
            UICommonDialog.OpenOKDialog("�e�X�g", "�e�X�g�_�C�A���O�ł���", Test);
        }

        void Test(int type)
        {
            Debug.Log("here");
        }
    }

}

