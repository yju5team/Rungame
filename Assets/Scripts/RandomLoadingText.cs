using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomLoadingText : MonoBehaviour
{
    public TextMeshProUGUI LoadingText;

    // Start is called before the first frame update
    void Start()
    {
        RandomText();
    }

    void RandomText()
    {
        var rand = Random.Range(1, 21);
        switch (rand)
        {
            case 1:
                LoadingText.text = "그날 백신들은 떠올렸다…";
                break;
            case 2:
                LoadingText.text = "나의 바이러스? 원한다면 주도록 하지. 잘 찾아봐. 이 세상 전부 거기에 두고 왔으니까.";
                break;
            case 3:
                LoadingText.text = "현실로 돌아가기엔 너무 늦었어.";
                break;
            case 4:
                LoadingText.text = "로딩 중... 너의 인내심도.";
                break;
            case 5:
                LoadingText.text = "이 게임은 0.0001%의 확률로 지금 안 열립니다. 오! 당신은 운이 좋군요.";
                break;
            case 6:
                LoadingText.text = "현실은 조작됐다. 여긴 진짜다.";
                break;
            case 7:
                LoadingText.text = "삶은 버그 투성이야. 이곳은 패치되지 않았어.";
                break;
            case 8:
                LoadingText.text = "프록시 연결 중... 흔적은 남기지 마.";
                break;
            case 9:
                LoadingText.text = "확산중.. 백신이 오고 있습니다. 당신의 생존 본능을 보여주세요!";
                break;
            case 10:
                LoadingText.text = "세상은 당신의 감염을 기다립니다.";
                break;
            case 11:
                LoadingText.text = "곧 세상이 당신의 힘을 알게 될 겁니다.";
                break;
            case 12:
                LoadingText.text = "견디고, 살아남았노라.";
                break;
            case 13:
                LoadingText.text = "아니, 통하지 않아.";
                break;
            case 14:
                LoadingText.text = "당신에게 주어진 기회는 단 한번 뿐입니다.";
                break;
            case 15:
                LoadingText.text = "미안하다 이거 보여주려고 어그로끌었다.. 나루토 사스케 싸움수준 ㄹㅇ실화냐? 진짜 세계관최강자들의 싸움이다.. 그찐따같던 나루토가 맞나? 진짜 나루토는 전설이다..진짜옛날에 맨날나루토봘는데 왕같은존재인 호카게되서 세계최강 전설적인 영웅이된나루토보면 진짜내가다 감격스럽고 나루토 노래부터 명장면까지 가슴울리는장면들이 뇌리에 스치면서 가슴이 웅장해진다.. 그리고 극장판에 카카시앞에 운석날라오는 거대한 걸 사스케가 갑자기 순식간에 나타나서 부숴버리곤 개간지나게 나루토가 없다면 마을을 지킬 자는 나밖에 없다 라며 바람처럼 사라진장면은 진짜 나루토처음부터 본사람이면 안울수가없더라 진짜 너무 감격스럽고 보루토를 최근에 알았는데 미안하다.. 지금20화보는데 진짜 나루토세대나와서 너무 감격스럽고 모두어엿하게 큰거보니 내가 다 뭔가 알수없는 추억이라해야되나 그런감정이 이상하게 얽혀있다.. 시노는 말이많아진거같다 좋은선생이고..그리고 보루토왜욕하냐 귀여운데 나루토를보는것같다 성격도 닮았어 그리고버루토에 나루토사스케 둘이싸워도 이기는 신같은존재 나온다는게 사실임?? 그리고인터닛에 쳐봣는디 이거 ㄹㅇㄹㅇ 진짜팩트냐?? 저적이 보루토에 나오는 신급괴물임?ㅡ 나루토사스케 합체한거봐라 진짜 ㅆㅂ 이거보고 개충격먹어가지고 와 소리 저절로 나오더라 ;; 진짜 저건 개오지는데.. 저게 ㄹㅇ이면 진짜 꼭봐야돼 진짜 세계도 파괴시키는거아니야 .. 와 진짜 나루토사스케가 저렇게 되다니 진짜 눈물나려고했다.. 버루토그라서 계속보는중인데 저거 ㄹㅇ이냐..? 하.. ㅆㅂ 사스케 보고싶다.. 진짜언제 이렇게 신급 최강들이 되었을까 옛날생각나고 나 중딩때생각나고 뭔가 슬프기도하고 좋기도하고 감격도하고 여러가지감정이 복잡하네.. 아무튼 나루토는 진짜 애니중최거명작임..";
                break;
            case 16:
                LoadingText.text = "언더테일 아시는구나! 혹시 모르시는분들에 대해 설명해드립니다 샌즈랑 언더테일의 세 가지 엔딩루트중 몰살엔딩의 최종보스로 진.짜.겁.나.어.렵.습.니.다 공격은 전부다 회피하고 만피가 92인데 샌즈의 공격은 1초당 60이 다는데다가 독뎀까지 추가로 붙어있습니다.. 하지만 이러면 절대로 게임을 깰 수 가없으니 제작진이 치명적인 약점을 만들었죠. 샌즈의 치명적인 약점이 바로 지친다는 것입니다. 패턴들을 다 견디고나면 지쳐서 자신의 턴을 유지한채로 잠에듭니다. 하지만 잠이들었을때 창을옮겨서 공격을 시도하고 샌즈는 1차공격은 피하지만 그 후에 바로날아오는 2차 공격을 맞고 죽습니다.";
                break;
            case 17:
                LoadingText.text = "내 목숨을 컴퓨터에.";
                break;
            case 18:
                LoadingText.text = "마따끄!";
                break;
            case 19:
                LoadingText.text = "내가 하늘에 서겠다.";
                break;
            case 20:
                LoadingText.text = "이런 데서 쓰고 싶진 않았는데! 똑똑히 봐둬라! 그리고 아무한테도 말하지 마라! 만해!!";
                break;



        }
    }
}
