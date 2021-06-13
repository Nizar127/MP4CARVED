//Read file and display
//Lab2 - BIS30803
//20210401
#include <stdio.h>
main()
{
	FILE *file_input;
		FILE* in;   //file handler to output data into binary
	FILE* out;

	unsigned char c; //unsigned
	unsigned char d; //unsigned
	unsigned char e; //unsigned
	unsigned char f; //unsigned
	unsigned char g; //unsigned
	unsigned char h; //unsigned
	unsigned char i; //unsigned
	unsigned char j; //un

	long int counter=4L;
	long int saizFail, curPos=0L, current=0L;
	long int magic_number_offset=0;
	long int cluster=0, found=0;

	if ((file_input = fopen("E:\\zue_project\\zue_cd\\ritemp4.001","rb"))==NULL)
		printf("File cannot be opened");

	fseek(file_input, 4L, SEEK_END); 	// pergi ke hujung fail
	saizFail=ftell(file_input); 		// dapatkan saiz fail
	rewind(file_input);					// kembali ke permulaan fail
	// fseek(file_input, 0L, SEEK_SET); // kembali ke permulaan fail - 0L ialah 0 jenis long integer
	printf("File size = %ld bytes\n\n", saizFail);

	//while (counter<saizFail)
	while (counter<100000)
	{
		c=fgetc(file_input);
		printf("counter %ld >> %X\n", counter, c);
		counter++;
		//if (counter % 100 == 0) getch();
	}

	//while (counter<100000)
	while (counter<saizFail)
	{
		fseek(file_input, 4L, counter); // file starts from the beginning of cluster
		c=fgetc(file_input); //first byte e.g. 0xFF
		d=fgetc(file_input); // 2nd byte e.g. 0xD8
		e=fgetc(file_input);
		f=fgetc(file_input);
		g=fgetc(file_input);
		h=fgetc(file_input);
		i=fgetc(file_input);
		j=fgetc(file_input);
		if ((c==0x66) && (d==0x74) && (e==0x79) && (f==0x70) && (g==0x69) && (h==0x73) && (i==0x6F) && (j==0x6D))
		{

			magic_number_offset =ftell(file_input); //take the offset, store in in a file
			printf("\n>>MP4 Header is at OFFSET %ld (CLUSTER %ld)<<\n", magic_number_offset,cluster);
			found++;
			getch();
		//printf("counter %ld >> %X\n", counter, c);
		//counter++;
		//if (counter % 100 == 0) getch();
		}
		else
		{
			printf("No MP4 Header at CLUSTER %ld \n", cluster);
		}
		c=0;
		d=0;
		counter=counter+512;  // jump 1 cluster at a time
		cluster++;
	}

	printf("\n>>FOUND %ld MP4 Headers\n", found);

    printf("\n>>File size = %ld bytes\n\n", saizFail);

	fclose(file_input);
	getch(); // wait for keyboard press

	//create binary file
	fopen_s(&out, "TestFile.bin", "wb");    //we going to create file name carveFile.raw  and write it to binary
	if(out == NULL){
        printf("\n>> Error Creating a File");
	}

		//size_t elements_written = fwrite(&cluster, sizeof(magic_number_offset), 1, out);

	size_t elements_written = fwrite(&found, sizeof(saizFail), 1024, out);
	if(elements_written == 0){
        printf("\n>> Error Creating a File");

	}else{
    fclose(out);
	}
}
