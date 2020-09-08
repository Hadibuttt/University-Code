#pragma once
#include "Stack.cpp"

class Stackdeclare
{
private:
	char Infix[50];
	char Postfix[50];
	int result;
	int countexp;
	int evaluation;

public:
	void getexpression()
	{
		cout << "PLEASE ENTER AN EXPRESSION" << endl;
		cin >> Infix;
		countexp++;
	};

	int precedence(char op)
	{
		switch (op)
		{
		case '+':
			return 1;
		case '-':
			return 1;
		case '*':
			return 2;
		case '/':
			return 2;
		case '^':
			return 3;
		default:
			return 0;
		}
	};

	void convert()
	{
		if (countexp == 0)
		{
			cout << "NO INFIX EXPRESSION ENTERED" << endl;
		}
		else
		{
			int j = 0;
			stack <char >s;
			int length = strlen(Infix);

			for (int i = 0; i < length; i++)
			{
				if (isdigit(Infix[i]))
				{
					Postfix[j++] = Infix[i];
				}
				else if (Infix[i] == '+' || Infix[i] == '-' || Infix[i] == '*' || Infix[i] == '/' || Infix[i] == '^')
				{
					if (!s.empty() && precedence(s.Top()) > precedence(Infix[i]))
					{
						Postfix[j++] = s.pop();
						s.push(Infix[i]);
					}
					else
					{
						s.push(Infix[i]);
					}

				}
				else if (Infix[i] == '(')
				{
					s.push(Infix[i]);
				}
				else if (Infix[i] == ')')
				{
					while (s.Top() != '(')
					{

						Postfix[j++] = s.pop();

					}
					s.pop();
				}
			}
			while (!s.empty())
			{

				Postfix[j++] = s.pop();
			}
			Postfix[j++] = '\0';
			cout << "CONVERTED INFIX TO POSTFIX EXPRESSION IS = " << Postfix << endl;

		}
	}

	void  evaluate()
	{
		if (countexp == 0)
		{
			cout << "PLEASE ENTER AN EXPRESSION IN INFIX FIRST" << endl;
		}
		else
		{
			if (countexp == 0)
			{
				cout << "CONVERT INFIX TO POSTFIX FIRST" << endl;
			}
			else
			{
				stack<int>s;
				char temp;
				int temp2;
				int op1;
				int op2;
				char value;
				int evaluationresult;
				int lenght = strlen(Postfix);

				for (int j = 0; j < lenght; j++)
				{
					if (isdigit(Postfix[j]))
					{
						temp = Postfix[j];

						temp2 = (int)temp - 48;
						s.push(temp2);
					}

					else if (Postfix[j] == '+' || Postfix[j] == '-' || Postfix[j] == '*' || Postfix[j] == '/' || Postfix[j] == '^')
					{
						op2 = s.pop();
						op1 = s.pop();
						value = Postfix[j];
						switch (value)
						{
						case '+':
							evaluation = op1 + op2;
							s.push(evaluation);
							break;
						case '-':
							evaluation = op1 - op2;
							s.push(evaluation);
							break;
						case '*':
							evaluation = op1 * op2;
							s.push(evaluation);
							break;
						case '/':
							evaluation = op1 / op2;
							s.push(evaluation);
							break;
						case '^':
							evaluation = 1;
							for (int loop = 1; loop <= op2; loop++) {
								evaluation = evaluation * op1;
							}
							s.push(evaluation);
							break;
						default:
							cout << "TRY AGAIN" << endl;
						}

					}
				}
				evaluationresult = s.pop();
				cout << " THE EVALUATED RESULT IS =" << evaluationresult << endl;
			}
		}
	}
};
