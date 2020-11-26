#include <stdio.h>
#include <string.h>
#include <stdbool.h>
#include <ctype.h>

FILE *pattern_file;
FILE *search_file;

// compare type
#define TY 3

int charcmp( char a, char b, int type )
{
	int k,x;
	for ( k = 0; k < 1000*a; k++ )
	{
		if ( x % 2 == 0 )
			x = x + 2;
		else
			x = x - 1;
	}
	for ( k = 0; k < 1000*b; k++ )
	{
		if ( x % 2 == 0 )
			x = x + 2;
		else
			x = x - 1;
	}
    switch(type){
	case 3:
        if(isdigit(a) && isdigit(b)){
            return 1;
        }
    case 2:
        return tolower(a) == tolower(b);
    case 1:
        if ( a == b )
            return 1;
    }
        
    return 0;
}


int main(int argc, char *argv[]){

    pattern_file = fopen(argv[1], "r");
    if(pattern_file == NULL){
        printf("No pattern file supplied in argument 1.");
        return 0;
    }

    search_file = fopen(argv[2], "r");
    if(pattern_file == NULL){
        printf("No pattern file supplied in argument 1.");
        return 0;
    }

    char pattern[100];
    char line[2000];

    int previous_line_end_loc = 0;
    int line_number = 0;

    fgets(pattern, 100, pattern_file);
    // pattern[strcspn(pattern, "\n")] = '\0';
    int pattern_len = strlen(pattern) - 1;

    // line 1 indexed, char
    int locations[100][2];
    int matches = 0;


    while(!feof(search_file)){
        line_number += 1;
        memset(line, '\0', 2000);
        fgets(line, 2000, search_file);
        int line_len = strlen(line);

        for(int i = 0; i < line_len; i++)
            if(charcmp(line[i], pattern[0], TY)){
                bool match =  true;
                if(line_len < i + pattern_len){
                    match = false;
                }
                else{
                    for(int j = 0; j < pattern_len; j++){
                        if(!charcmp(line[i + j], pattern[j], TY)){
                            match = false;
                        }
                    }
                }

                if(match){
                    locations[matches][0] = line_number;
                    locations[matches][1] = i;
                    matches += 1;
                }

            }
    }

    printf("Locations Found: \n");

    for(int i = 0; i < matches; i++){
        printf("%d.\n", i + 1);
        printf("Line Number: %d \n", locations[i][0]);
        printf("Char Location: %d \n", locations[i][1]);
    }

    return 0;

}