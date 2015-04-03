/**
 * Author pille72
 */
#include <stdio.h>
#include <sys/types.h>
#include <dirent.h>
#include <string.h>
#include <unistd.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
  char* version = "1.0";
  DIR *dp;
  struct dirent *ep;
  FILE * fp;
  char* fileName;
  long size;
  int debug = 0;
  int chDir = 0;
  char* fileSizeType = "B";
  float sizeFloat;

  char* maxFileName;
  float maxSize = 0;

  if(argv[1] != NULL) {
    if(strncmp(argv[1], "-v", 2) == 0) {
      printf("maxfilesize version %s \n", version);
      exit(1);
    }
    if(chdir(argv[1]) == 0) {
      dp = opendir(".");
    }
    else {
      printf("Failed to parse directory\n");
      printf("Usage: DIR [-debug] \n");
      exit(EXIT_FAILURE);
    }
  }
  else {
    exit(EXIT_FAILURE);
  }

  if(argv[2] != NULL) {
    if(strncmp(argv[2], "-debug", 6) == 0) {
      debug = 1;
    }
  }

  if(dp != NULL) {
    if(debug == 1) {
      printf("Dir: ");
      printf("%s \n", argv[1]);
      printf("---\nFiles in directory: \n");
    }

    while ((ep = readdir (dp)) != NULL) {
      fileName = ep->d_name;
      if( strncmp(fileName, ".", 1) != 0  && strncmp(fileName, "..", 2) != 0) {
        fp = fopen(fileName, "r");
        fseek(fp, 0L, SEEK_END);
        size = ftell(fp);
        sizeFloat = (float) size;

        if(sizeFloat > 1024) {
          fileSizeType = "KB";
          sizeFloat = sizeFloat / 1024;
          if(sizeFloat > 1024) {
            fileSizeType = "MB";
            sizeFloat = sizeFloat / 1024;
          }
        }

        if(debug == 1) {
          printf("%-50s ", fileName);
          printf("\t\t%.2f", sizeFloat);
          printf(" %s\n", fileSizeType);
        }

        if(maxSize < sizeFloat) {
          maxSize = sizeFloat;
          maxFileName = fileName;
        }
      }
    }

    if(debug == 1) {
      printf("---\n");
    }

    if(debug == 1) {
      printf("Max file: ");
    }

    printf("%s ", maxFileName);
    printf("\t %.2f", maxSize);
    printf(" %s\n", fileSizeType);

    (void) closedir (dp);
  }
  else {
    printf("Failed! \n");
    printf("Usage: DIR [-debug] \n");
  }
  return 0;
}
