#pragma once
#include<string>

class EmailService
{
public:
	EmailService();
	~EmailService();
	bool Send(std::string message);
	std::string Receive();
};

