#include <iostream>
#include <string>

using namespace std;

/// <summary>
/// Remove extra spaces.
/// Source: https://www.geeksforgeeks.org/remove-extra-spaces-string/.
/// </summary>
/// <param name="str">Input string.</param>
void removeSpaces(string& str)
{
	int length = str.length();
	int i = 0, j = -1;
	bool spaceFound = false;

	while (++j < length && str[j] == '_');

	while (j < length)
	{
		if (str[j] != '_')
		{
			str[i++] = str[j++];
			spaceFound = false;
		}
		else if (str[j++] == '_')
		{
			if (!spaceFound)
			{
				str[i++] = '_';
				spaceFound = true;
			}
		}
	}

	if (i <= 1 || (i > 1 && str[i - 1] != '_' && str[i] != '_'))
		str.erase(str.begin() + i, str.end());
	else
		str.erase(str.begin() + i - 1, str.end());
}

int main()
{
	std::cout << "Removing extra spaces for test strings.\n\n";

	string strs[] =
	{
		"",
		"_",
		"___",
		"1_2",
		"111_222",
		"1__2",
		"_1__2_",
		"_____1____2____",
		"_On__my___home_world",
	};

	for (int i = 0; i < 9; i++)
	{
		std::cout << "\"" + strs[i] + "\"" << " > ";
		removeSpaces(strs[i]);
		std::cout << "\"" + strs[i] + "\"" << '\n';
	}

	string str = "";
	std::getline(std::cin, str);

	return 0;
}