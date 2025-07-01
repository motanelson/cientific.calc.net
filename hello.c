// Copyright 2011 The Emscripten Authors.  All rights reserved.
// Emscripten is available under two separate licenses, the MIT license and the
// University of Illinois/NCSA Open Source License.  Both these licenses can be
// found in the LICENSE file.
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <string.h>
#include <time.h>
#include <math.h>

#include <emscripten.h>
void Alert(char *c){
    char buffer[4096]="alert(\"";
    //printf("%s\n",buffer);
    strcat(buffer,c);
    strcat(buffer,"\")");
    //printf("%s\n",buffer);
    emscripten_run_script_string(buffer);
        
}
void onstart(){
    Alert("operation system start....");
}
void onend(){
    Alert("operation system end....");
}
void kernel_main(){
    Alert("hello world...");
}

int main() {
    onstart();
    kernel_main();
    onend();
    
    return 0;
}
