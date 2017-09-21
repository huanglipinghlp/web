#include<iostream>
#include<stdio.h>
#include<time.h>
#include<ctime> 
using namespace std;


//初始化楼层信息
//以春晖楼为例无地下层，只有1-6层
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
	cout << "请输入目前等候电梯的乘客的人数：" ;
	cin >> p;
	return p;
}

int InitPassenger1(int n)
{
	int If,Of,Et;
	cout << "请输入所在楼层（1-6）：";
	cin >> If;
	while(If < 1 || If > 6)
	{
		cout << "  输入错误！" << endl;
		cout << "请输入所在楼层（1-6）：";
		cin >> If;
	}
	passenger[n].InFloor = If;
	cout << "请输入目标楼层（1-6）：";
	cin >> Of;
	while(Of < 1 || Of > 6 || Of == If)
	{
		cout << "  输入错误！" << endl;
		cout << "请输入所在楼层（1-6）：";
		cin >> Of;
	}
	passenger[n].OutFloor = Of;
	cout << "请输入容忍时间(大于零)：";
	cin >> Et;
	while(Et < 1)
	{
		cout << "  输入错误！" << endl;
		cout << "请输入容忍时间(大于零)：";
		cin >> Et;
	}
	passenger[n].EndureTime = Et;
	passenger[n].NextTime =0;
	passenger[n].LeaveTime = Et;
	if(If < Of)
	{
		passenger[n].UpOrDown = -1;
		 printf("%▲\n");
	}

	else
	{
		passenger[n].UpOrDown = 1;
		printf("%▼\n");
	
	}
	return 0;
}

int InitPassenger2(int n)
{
	int If,Of,Et;
	int nt;
	cout << "************************************" << endl;
	
	cout << "请输入第 "  << n+1 << "个乘客的详细信息：" << endl;
		
	
	cout << "请输入所在楼层：";
	cin >> If;
	while(If < 1 || If > 6)
	{
		cout << "  输入错误！" << endl;
		cout << "请输入所在楼层（1-6）：";
		cin >> If;
	}
	passenger[n].InFloor = If;
	cout << "请输入目标楼层：";
	cin >> Of;
	while(Of < 1 || Of > 6 || Of == If)
	{
		cout << "  输入错误！" << endl;
		cout << "请输入所在楼层（1-6）：";
		cin >> Of;
	}
	passenger[n].OutFloor = Of;
	cout << "请输入容忍时间：";
	cin >> Et;
	while(Et < 1)
	{
		cout << "  输入错误！" << endl;
		cout << "请输入容忍时间(大于零)：";
		cin >> Et;
	}
	passenger[n].EndureTime = Et;
	cout << "请输入下一位乘客到达的时间（秒）：" ;
	cin >> nt;
	while(nt < 1)
	{
		cout << "  输入错误！" << endl;
		cout << "请输入下一位乘客到达的时间（秒）：";
		cin >> nt;
	}
	passenger[n].NextTime = nt;
	passenger[n].LeaveTime = passenger[n-1].LeaveTime - passenger[n-1].EndureTime + passenger[n-1].NextTime + passenger[n].EndureTime ;
	//cout << "fangqishijian  "<< passenger[n].LeaveTime  << endl;

	if(If < Of)
	{
		passenger[n].UpOrDown = -1;
		 printf("%▲\n");
	}
	else
	{
		passenger[n].UpOrDown = 1;
		printf("%▼\n");
	
	}
	
	return 0;
}
int SetPassenger1(int sp)
{
	int i ;
	for(i = 0;i< sp-1;i++)
	{
		cout << "************************************" << endl;
	
		cout << "请输入第 "  << i+1 << "个乘客的详细信息：" << endl;
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
	
	cout << "电梯系统设定" << endl;
	
	cout << endl;
	cout << "上/下一层楼花费的时间(MoveTime):";
	cin >> MT;
	elevator[1].MoveTime = elevator[2].MoveTime ;
	cout << "关门花费的时间（CloseingTime）：";
	cin >> CT;
	elevator[1].CloseingTime = elevator[2].CloseingTime ;
	cout << "开门花费的时间(opening):";
	cin >>OT;
	elevator[1].OpeningTime = elevator[2].OpeningTime ;
	cout << "电梯开门后等待的时间（IdleTime）：";
	cin >> IT;
	elevator[1].IdleTime = elevator[2].IdleTime ;
	cout << "乘客的平均移动时间为（PMoveingTime）：";
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
	//电梯目前的位置
	srand((unsigned int)time(0));//播种子
	IF = rand()%5+1;
	elevator[e].InFloor = IF ;
	//cout << "" <<  << endl;


	//电梯内乘客的人数
	srand((unsigned int)time(0));//播种子
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
	//电梯目前的位置
	srand((unsigned int)time(0));//播种子
	IF = rand()%(6-2+1)+2;
	elevator[e].InFloor = IF ;
	
	//电梯内乘客的人数
	srand((unsigned int)time(0));//播种子
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
	srand((unsigned int)time(0));//播种子
	//决定电梯的上下问题。
	e = rand()%2;//0为下，1为上
	if(e == 1)
		GetPSumAndFloorUp(0);
	else
		GetPSumAndFloorDown(0);


	e = rand()%2;//0为下，1为上
	if(e == 1)
		GetPSumAndFloorUp(1);
	else
		GetPSumAndFloorDown(1);

	return 0;
}

int ShowElevatorManagement()
{
	cout << "        --电梯信息-- " << endl;
	cout << endl;
	InitFloor();
	cout << "------------elevator------------------"<< endl;
	cout << "A电梯所在楼层为位：" << elevator[0].InFloor << "楼, " << "将停止的楼层为："<< elevator[0].OutFloor[0];
	if(elevator[0].OutFloor[1] != 0)
	{
		cout << "," << elevator[0].OutFloor[1] ;
		if(elevator[0].OutFloor [2] != 0)
		{
			cout << "," << elevator[0].OutFloor[2];
		}
	}
	cout << "电梯内乘客量为：" << elevator[0].PSum ;
	cout<< endl ;

	cout << "B电梯所在楼层为位：" << elevator[1].InFloor << "楼, " << "将停止的楼层为："<< elevator[1].OutFloor[0];
	if(elevator[1].OutFloor[1] != 0)
	{
		cout << "," << elevator[1].OutFloor[1] ;
		if(elevator[1].OutFloor [2] != 0)
		{
			cout << "," << elevator[1].OutFloor[2];
		}
	}
	cout << "电梯内乘客量为：" << elevator[1].PSum ;
	cout<< endl ;
	
	return 0;
}



int Passenger()
{
	int nl,nup,ndown;//n表示排队的总人数，nup为排队上楼的人数，ndown为排队下楼的人数
	int wnup,wndown;
	//使用新种子产生随机数，每次都不一样
	srand((unsigned int)time(0));//播种子
	nl = rand()%30;
	nup = rand()%nl;
	ndown = nl-nup;
	wnup = nup+1;
	wndown = ndown+1;
	cout << endl;
	cout << "目前有 " << nl << " 人在排队" <<endl;cout << endl;
	cout << "其中欲上楼的人数为：" << nup << " 人." << endl;
	cout << "其中欲下楼的人数为：" << ndown << " 人." << endl;cout << endl;
	cout << "若您上楼，则您将排在上楼的第 " << wnup << " 位." << endl;
	cout << "若您下楼，则您将排在下楼的第 " << wndown << " 位." << endl;
	cout << endl;
	
	return 0;
}
int main()
{
	//乘客的情况。
	int p,wp;
	cout << "         乘客信息" << endl;
	cout << endl;
	cout << "请输入目前等候电梯的乘客的人数：" ;
	cin >> p;
	SetPassenger1(p);
	cout << endl;
	cout << "请输入将要出现的乘客信息:" << endl;
	wp = GetNestPa();
	SetPassenger2(p,wp);
	cout << endl;

	//电梯情况
	ShowElevatorManagement();

	
	
	int i,j,cf;//i表示
	
	
	return 0;
}

