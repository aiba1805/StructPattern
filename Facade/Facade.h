#pragma once
#include"EmailService.h"
#include"FinanceService.h"
class Facade {
private:
	EmailService* email_service;
	FinanceService* finance_service;
public:
	Facade();
	void Calculate();
	bool SendMsg(std::string msg);
};
