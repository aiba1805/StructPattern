#include <iostream>
using namespace std;

class UniqueWeapon {
public:
	virtual int getDamage() = 0;
};

class Unique_Weapon_v_1 : public UniqueWeapon{
	int ammunition;		// боезапас
	int damage;			// урон
public:
	Unique_Weapon_v_1() :damage(555) {}
	int getDamage() {
		return damage;
	}
};

class Unique_Weapon_v_3 : public UniqueWeapon {
	int ammunition;		// боезапас
	int damage;			// урон
public:
	Unique_Weapon_v_3() :damage(89955) {}
	int getDamage() {
		return damage;
	}
};
class Player_Weapon {
public:
	virtual ~Player_Weapon() {}
	virtual int getDamage(int) = 0;
};

class Unique_Weapon_v_2 : public Player_Weapon {
	int ammunition;			// боезапас
	int	range_of_fire;		// дальность стрельбы
	float penetrating_power;// пробивающая способность
public:
	Unique_Weapon_v_2() :range_of_fire(1000), penetrating_power(4.4f) {}
	int getDamage(int distance) {
		return distance > range_of_fire ?  0 : 
			(range_of_fire - distance)*penetrating_power;
	}
};


class Adapter : public Player_Weapon {
public:
	Adapter(UniqueWeapon* p) : p_UW1(p) {
	}
	~Adapter() {
		delete p_UW1;
	}
	int getDamage(int distance) {
		if (distance > 500)
			return 0;
		return p_UW1->getDamage()*(distance / 255.);
		//return p_UW1->getDamage();
	}
private:
	UniqueWeapon* p_UW1;
};


enum Unique_Weapon_Type {
	v1, v2,v3
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
	cout << "Урон по врагу находящемуся на расстоянии " << distance << " метров = " << p->getDamage(distance) << endl;
	delete p;
	
	p = WeaponCreator::CreateUniqueWeapon(v2);
	cout << "Урон по врагу находящемуся на расстоянии " << distance << " метров = " << p->getDamage(distance) << endl;
	delete p;

	p = WeaponCreator::CreateUniqueWeapon(v3);
	cout << "Урон по врагу находящемуся на расстоянии " << distance << " метров = " << p->getDamage(distance) << endl;
	delete p;

	cin.get();
}