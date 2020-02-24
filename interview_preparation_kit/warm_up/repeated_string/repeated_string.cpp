#include <bits/stdc++.h>

using namespace std;

// Complete the repeatedString function below.
long repeatedString(string s, long n) {
    
    long count, rep, rest = 0;

    for(int i = 0; i < s.size(); i++){
        if(s[i] == 'a')
            count++;
    }
    
    rep = n / (long)s.size();
    count = rep * count;
    rest = n % (long)s.size();

    for(int i = 0; i < rest; i++)
        if(s[i] == 'a')
            count++;    

    return std::count(s.begin(), s.end(), 'a') * n / s.size() + std::count(s.begin(), n % s.size(), 'a');
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    long n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    long result = repeatedString(s, n);

    fout << result << "\n";

    fout.close();

    return 0;
}
