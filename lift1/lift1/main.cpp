#include<iostream>
#include<stdio.h>
#include<time.h>
#include<ctime> 
using namespace std;


//��ʼ��¥����Ϣ
//�Դ���¥Ϊ���޵��²㣬ֻ��1-6��
struct passenger
{
	int InFloor;
	int OutFloor;
	int EndureTime;
	int NextTime;
	int UpOrDown;
	int LeaveTime;
}passenger[20];

struct elevator
{
	int InFloor;
	int OutFloor[3];
	int MoveTime;
	int CloseingTime;
	int OpeningTime;
	int IdleTime;
	int PMoveingTime;
	int PSum;
	int UpOrDown;
}elevator[2];

int GetNestPa()
{
	int p;
	cout << "������Ŀǰ�Ⱥ���ݵĳ˿͵�������" ;
	cin >> p;
	return p;
}

int InitPassenger1(int n)
{
	int If,Of,Et;
	cout << "����������¥�㣨1-6����";
	cin >> If;
	while(If < 1 || If > 6)
	{
		cout << "  �������" << endl;
		cout << "����������¥�㣨1-6����";
		cin >> If;
	}
	passenger[n].InFloor = If;
	cout << "������Ŀ��¥�㣨1-6����";
	cin >> Of;
	while(Of < 1 || Of > 6 || Of == If)
	{
		cout << "  �������" << endl;
		cout << "����������¥�㣨1-6����";
		cin >> Of;
	}
	passenger[n].OutFloor = Of;
	cout << "����������ʱ��(������)��";
	cin >> Et;
	while(Et < 1)
	{
		cout << "  �������" << endl;
		cout << "����������ʱ��(������)��";
		cin >> Et;
	}
	passenger[n].EndureTime = Et;
	passenger[n].NextTime =0;
	passenger[n].LeaveTime = Et;
	if(If < Of)
	{
		passenger[n].UpOrDown = -1;
		 printf("%��\n");
	}

	else
	{
		passenger[n].UpOrDown = 1;
		printf("%��\n");
	
	}
	return 0;
}

int InitPassenger2(int n)
{
	int If,Of,Et;
	int nt;
	cout << "************************************" << endl;
	
	cout << "������� "  << n+1 << "���˿͵���ϸ��Ϣ��" << endl;
		
	
	cout << "����������¥�㣺";
	cin >> If;
	while(If < 1 || If > 6)
	{
		cout << "  �������" << endl;
		cout << "����������¥�㣨1-6����";
		cin >> If;
	}
	passenger[n].InFloor = If;
	cout << "������Ŀ��¥�㣺";
	cin >> Of;
	while(Of < 1 || Of > 6 || Of == If)
	{
		cout << "  �������" << endl;
		cout << "����������¥�㣨1-6����";
		cin >> Of;
	}
	passenger[n].OutFloor = Of;
	cout << "����������ʱ�䣺";
	cin >> Et;
	while(Et < 1)
	{
		cout << "  �������" << endl;
		cout << "����������ʱ��(������)��";
		cin >> Et;
	}
	passenger[n].EndureTime = Et;
	cout << "��������һλ�˿͵����ʱ�䣨�룩��" ;
	cin >> nt;
	while(nt < 1)
	{
		cout << "  �������" << endl;
		cout << "��������һλ�˿͵����ʱ�䣨�룩��";
		cin >> nt;
	}
	passenger[n].NextTime = nt;
	passenger[n].LeaveTime = passenger[n-1].LeaveTime - passenger[n-1].EndureTime + passenger[n-1].NextTime + passenger[n].EndureTime ;
	//cout << "fangqishijian  "<< passenger[n].LeaveTime  << endl;

	if(If < Of)
	{
		passenger[n].UpOrDown = -1;
		 printf("%��\n");
	}
	else
	{
		passenger[n].UpOrDown = 1;
		printf("%��\n");
	
	}
	
	return 0;
}
int SetPassenger1(int sp)
{
	int i ;
	for(i = 0;i< sp-1;i++)
	{
		cout << "************************************" << endl;
	
		cout << "������� "  << i+1 << "���˿͵���ϸ��Ϣ��" << endl;
		InitPassenger1(i);
		cout << passenger[i].LeaveTime  << endl;

	}
	InitPassenger2(sp-1);
	cout << passenger[sp-1].LeaveTime  << endl;

	return 0;
	
}

int SetPassenger2(int dp,int sp)
{
	int i ;
	for(i = dp;i< dp+sp;i++)
	{
		InitPassenger2(i);
		cout << passenger[i].LeaveTime  << endl;

	}
	
	return 0;
	
}


int InitFloorConfig()
{
	int MT;
	int CT;
	int OT;
	int IT;
	int PMT;
	
	cout << "����ϵͳ�趨" << endl;
	
	cout << endl;
	cout << "��/��һ��¥���ѵ�ʱ��(MoveTime):";
	cin >> MT;
	elevator[1].MoveTime = elevator[2].MoveTime ;
	cout << "���Ż��ѵ�ʱ�䣨CloseingTime����";
	cin >> CT;
	elevator[1].CloseingTime = elevator[2].CloseingTime ;
	cout << "���Ż��ѵ�ʱ��(opening):";
	cin >>OT;
	elevator[1].OpeningTime = elevator[2].OpeningTime ;
	cout << "���ݿ��ź�ȴ���ʱ�䣨IdleTime����";
	cin >> IT;
	elevator[1].IdleTime = elevator[2].IdleTime ;
	cout << "�˿͵�ƽ���ƶ�ʱ��Ϊ��PMoveingTime����";
	cin >> PMT;
	elevator[1].PMoveingTime = elevator[2].PMoveingTime ;
	return 0;
}

int GetPSumAndFloorUp(int e)
{
	int IF;
	int OF[3];
	int PSum,PSum1,PSum2;
	//int UOrD;
	//����Ŀǰ��λ��
	srand((unsigned int)time(0));//������
	IF = rand()%5+1;
	elevator[e].InFloor = IF ;
	//cout << "" <<  << endl;


	//�����ڳ˿͵�����
	srand((unsigned int)time(0));//������
	PSum = rand()%12+1;
	elevator[e].PSum = PSum;
	

	//[0]
	if(PSum == 1)
	{
		elevator[e].OutFloor [0] = rand()%(6-IF)+(IF+1);
	}
	else
	{
		if(IF < 5)
		{
			if(IF<4)
			{
		PSum1 = rand()%PSum;
		while(PSum1 == 0)
		{
			PSum1 = rand()%PSum;
		}
		PSum2 = PSum - PSum1;
		//[0,1,2]
		if(PSum2 != 0)
		{
			for(int i=0;i < 3;i++)
			{
				elevator[e].OutFloor[0] = rand()%(4-IF)+(IF+1);
				
				elevator[e].OutFloor [1] = rand()%(5-elevator[e].OutFloor[0])+(elevator[e].OutFloor[0]+1);
				elevator[e].OutFloor [2] = rand()%(6-elevator[e].OutFloor[1])+(elevator[e].OutFloor[1]+1);
			}
		}
			}

			else
			{
				elevator[e].OutFloor[0] = rand()%(5-elevator[e].InFloor )+(elevator[e].InFloor+1);
				elevator[e].OutFloor[1] = rand()%(6-elevator[e].OutFloor[0])+(elevator[e].OutFloor[0]+1);
			}
		}
	}
	return 0;
}

int GetPSumAndFloorDown(int e)
{
	int IF;
	int OF[3];
	int PSum,PSum1,PSum2;
	//int UOrD;
	//����Ŀǰ��λ��
	srand((unsigned int)time(0));//������
	IF = rand()%(6-2+1)+2;
	elevator[e].InFloor = IF ;
	
	//�����ڳ˿͵�����
	srand((unsigned int)time(0));//������
	PSum = rand()%12+1;
	elevator[e].PSum ;

	//[0]
	if(PSum == 1)
	{
		elevator[e].OutFloor [0] = rand()%((IF-1)-1+1)+1;
	}
	else
	{
		if(IF > 1)
		{
			if(IF>2)
			{
		PSum1 = rand()%PSum;
		while(PSum1 == 0)
		{
			PSum1 = rand()%PSum;
		}
		PSum2 = PSum - PSum1;
		//[0,1,2]
		if(PSum2 != 0)
		{
			for(int i=0;i < 3;i++)
			{
				elevator[e].OutFloor[0] = rand()%((IF-1)-3+1)+3;
				elevator[e].OutFloor [1] = rand()%((elevator[e].OutFloor[0]-1)-2+1)+2;
				elevator[e].OutFloor [2] = rand()%((elevator[e].OutFloor[1]-1)-1+1)+1;
			}
		}
			}

			else
			{
				elevator[e].OutFloor[0] = rand()%((IF-1)-2+1)+2;
				elevator[e].OutFloor[1] = rand()%((elevator[e].OutFloor[0]-1)-1+1)+1;
			}
		}
	}
	return 0;
}

int InitFloor()
{
	InitFloorConfig();
	int e;
	srand((unsigned int)time(0));//������
	//�������ݵ��������⡣
	e = rand()%2;//0Ϊ�£�1Ϊ��
	if(e == 1)
		GetPSumAndFloorUp(0);
	else
		GetPSumAndFloorDown(0);


	e = rand()%2;//0Ϊ�£�1Ϊ��
	if(e == 1)
		GetPSumAndFloorUp(1);
	else
		GetPSumAndFloorDown(1);

	return 0;
}

int ShowElevatorManagement()
{
	cout << "        --������Ϣ-- " << endl;
	cout << endl;
	InitFloor();
	cout << "------------elevator------------------"<< endl;
	cout << "A��������¥��Ϊλ��" << elevator[0].InFloor << "¥, " << "��ֹͣ��¥��Ϊ��"<< elevator[0].OutFloor[0];
	if(elevator[0].OutFloor[1] != 0)
	{
		cout << "," << elevator[0].OutFloor[1] ;
		if(elevator[0].OutFloor [2] != 0)
		{
			cout << "," << elevator[0].OutFloor[2];
		}
	}
	cout << "�����ڳ˿���Ϊ��" << elevator[0].PSum ;
	cout<< endl ;

	cout << "B��������¥��Ϊλ��" << elevator[1].InFloor << "¥, " << "��ֹͣ��¥��Ϊ��"<< elevator[1].OutFloor[0];
	if(elevator[1].OutFloor[1] != 0)
	{
		cout << "," << elevator[1].OutFloor[1] ;
		if(elevator[1].OutFloor [2] != 0)
		{
			cout << "," << elevator[1].OutFloor[2];
		}
	}
	cout << "�����ڳ˿���Ϊ��" << elevator[1].PSum ;
	cout<< endl ;
	
	return 0;
}



int Passenger()
{
	int nl,nup,ndown;//n��ʾ�Ŷӵ���������nupΪ�Ŷ���¥��������ndownΪ�Ŷ���¥������
	int wnup,wndown;
	//ʹ�������Ӳ����������ÿ�ζ���һ��
	srand((unsigned int)time(0));//������
	nl = rand()%30;
	nup = rand()%nl;
	ndown = nl-nup;
	wnup = nup+1;
	wndown = ndown+1;
	cout << endl;
	cout << "Ŀǰ�� " << nl << " �����Ŷ�" <<endl;cout << endl;
	cout << "��������¥������Ϊ��" << nup << " ��." << endl;
	cout << "��������¥������Ϊ��" << ndown << " ��." << endl;cout << endl;
	cout << "������¥��������������¥�ĵ� " << wnup << " λ." << endl;
	cout << "������¥��������������¥�ĵ� " << wndown << " λ." << endl;
	cout << endl;
	
	return 0;
}
int main()
{
	//�˿͵������
	int p,wp;
	cout << "         �˿���Ϣ" << endl;
	cout << endl;
	cout << "������Ŀǰ�Ⱥ���ݵĳ˿͵�������" ;
	cin >> p;
	SetPassenger1(p);
	cout << endl;
	cout << "�����뽫Ҫ���ֵĳ˿���Ϣ:" << endl;
	wp = GetNestPa();
	SetPassenger2(p,wp);
	cout << endl;

	//�������
	ShowElevatorManagement();

	
	
	int i,j,cf;//i��ʾ
	
	
	return 0;
}

