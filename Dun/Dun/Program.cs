using System;

namespace SpartaRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }

    public class Game //게임 클래스
    {
        public void Start() //시작 매뉴
        {
            Console.Clear();
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.\n");

            while (true)
            {
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("0. 게임 종료");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");

                string input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        ShowStatus();
                        break;
                    case "2":
                        ShowInventory();
                        break;
                    case "3":
                        ShowShop();
                        break;
                    case "0":
                        Console.WriteLine("게임을 종료합니다.");
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다.\n");
                        break;
                }
            }
        }

        void ShowStatus() //상태창 관리
        {
            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
            Console.WriteLine("Lv. 01");
            Console.WriteLine("Chad ( 전사 )");
            Console.WriteLine("공격력 : 10");
            Console.WriteLine("방어력 : 5");
            Console.WriteLine("체 력 : 100");
            Console.WriteLine("Gold : 1500 G\n");

            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            if (Console.ReadLine() == "0")
                Console.Clear();
        }

        void ShowInventory() //인벤토리 관리
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("- 1 [E]무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            Console.WriteLine("- 2 [E]스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
            Console.WriteLine("- 3 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.\n");

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            string input = Console.ReadLine();
            if (input == "1")
            {
                ManageEquip();
            }
            else if (input == "0")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.\n");
            }
        }

        void ManageEquip() //장착관리
        {
            Console.Clear();
            Console.WriteLine("장착 관리 화면입니다. (여기서는 기능 없이 돌아가기만 구현..ㅠ)\n");

            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            if (Console.ReadLine() == "0")
            {
                Console.Clear();
                ShowInventory();
            }
        }

        void ShowShop() //상점관리
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine("800 G\n");

            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
            Console.WriteLine("- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
            Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
            Console.WriteLine("- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
            Console.WriteLine("- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
            Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료\n");

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            string input = Console.ReadLine();
            if (input == "1")
            {
                ShowPurchase();
            }
            else if (input == "0")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.\n");
            }
        }

        void ShowPurchase()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine("800 G\n");

            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("- 1 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
            Console.WriteLine("- 2 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
            Console.WriteLine("- 3 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
            Console.WriteLine("- 4 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
            Console.WriteLine("- 5 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
            Console.WriteLine("- 6 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료\n");

            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            if (Console.ReadLine() == "0")
            {
                Console.Clear();
                ShowShop();
            }
        }
    }
}
