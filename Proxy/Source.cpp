#include<iostream>
using namespace std;



class Player_Weapon {
public:
	virtual ~Player_Weapon() {}
	virtual int getDamage(int) = 0;
};

class Unique_Weapon_v_1 {
	int ammo;

public:
	int getDamage(int distance) {

	}
};

class Proxy {
	Unique_Weapon_v_1 * p;
public:
	Proxy(Unique_Weapon_v_1*p) :p (p){}
	int getDamage(int distance) {
		return p->getDamage(distance);
	}
};

class Unique_Weapon_v_2 : public Player_Weapon {
	int ammunition;			// ��������
	int	range_of_fire;		// ��������� ��������
	float penetrating_power;// ����������� �����������
public:
	Unique_Weapon_v_2() :range_of_fire(1000), penetrating_power(4.4f) {}
	int getDamage(int distance) {
		return distance > range_of_fire ? 0 :
			(range_of_fire - distance)*penetrating_power;
	}
};

class Unique_Weapon_v_1 {
	int ammunition;		// ��������
	int damage;			// ����
public:
	Unique_Weapon_v_1() :damage(555) {}
	int getDamage(int) {
		return damage;
	}
};

enum Unique_Weapon_Type {
	v1, v2, v3
};

class WeaponCreator {
public:
	static Player_Weapon* CreateUniqueWeapon(Unique_Weapon_Type type) {
		switch (type) {
		case v1:
			return new Adapter(new Unique_Weapon_v_1);
		case v2:
			return new Unique_Weapon_v_2;
		case v3:
			return new Adapter(new Unique_Weapon_v_3);
		}
	}
};



int main() {

	setlocale(LC_ALL, "RUSSIAN");
	Player_Weapon* p = WeaponCreator::CreateUniqueWeapon(v1);
	int distance = 123;
	cout << "���� �� ����� ������������ �� ���������� " << distance << " ������ = " << p->getDamage(distance) << endl;
	delete p;

	p = WeaponCreator::CreateUniqueWeapon(v2);
	cout << "���� �� ����� ������������ �� ���������� " << distance << " ������ = " << p->getDamage(distance) << endl;
	delete p;

	p = WeaponCreator::CreateUniqueWeapon(v3);
	cout << "���� �� ����� ������������ �� ���������� " << distance << " ������ = " << p->getDamage(distance) << endl;
	delete p;

	cin.get();
}