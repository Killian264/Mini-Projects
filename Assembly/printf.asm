%include "/usr/local/share/csc314/asm_io.inc"


segment .data

        str1 db "Hello world", 10,0
        str2 db "str3 is '%s', isn't that cool?",10,0
        str3 db "woot woot",0
        str4 db "%c is a char, but so is %%, %s again!",10,0
        str5 db "%d is a number, but so is %dsd",10,0

segment .bss


segment .text
        global  asm_main

asm_main:
        push    ebp
        mov             ebp, esp
        ; ********** CODE STARTS HERE **********

        push str1
        call printf
        add esp, 4

;       mov eax, 4
;       mov ebx, 1
;       mov ecx, str1
;       mov edx, 12
;       int 0x80

        push str3
        push str2
        call printf
        add esp, 8

        push str3
        push 'A'
        push str4
        call printf
        add esp, 8


        push 12312
        push 23213
        push str5
        call printf
        add esp, 12

        mov eax, 5
        add eax, 0x30
        push eax
        call printchar
        add esp, 4

        ; *********** CODE ENDS HERE ***********
        mov             eax, 0
        mov             esp, ebp
        pop             ebp
        ret

printf:
        push ebp
        mov ebp, esp

        sub esp, 8
        ; main loop counter
        mov DWORD[ebp - 4], 0
        ; number * 4 to get to next stack DWORD inc when % not %%
        mov DWORD[ebp - 8], 3
        loop:
                mov ecx, DWORD[ebp - 4]
                mov eax, DWORD[ebp + 8]
                cmp BYTE [eax + ecx], 0
                je loopend


                cmp BYTE[eax + ecx], '%'
                        jne percentend
                                inc DWORD[ebp - 4]
                                inc ecx
                                cmp BYTE[eax + ecx], 's'
                                jne sEnd
                                        mov edx, DWORD[ebp - 8]
                                        mov eax, DWORD[ebp + 4 * edx]
                                        push eax
                                        call printstring
                                        add esp, 4
                                        inc DWORD[ebp - 4]
                                        inc DWORD[ebp - 8]
                                        jmp loop
                                sEnd:
                                cmp BYTE[eax + ecx], '%'
                                        je percentend
                                cmp BYTE[eax + ecx], 'c'
                                jne cEnd
                                        mov edx, DWORD[ebp - 8]
                                        push DWORD[ebp + 4 * edx]
                                        call printchar
                                        add esp, 4

                                        inc DWORD[ebp - 4]
                                        inc DWORD[ebp - 8]
                                        jmp loop
                                cEnd:
                                cmp BYTE[eax + ecx], 'd'
                                jne percentend

                                        mov edx, DWORD[ebp - 8]
                                        push DWORD[ebp + 4 * edx]
                                        call printnumber
                                        add esp, 4

                                        inc DWORD[ebp-4]
                                        inc DWORD[ebp-8]
                                        jmp loop
                percentend:
                        push DWORD[eax + ecx]
                        call printchar
                        add esp, 4
                        inc DWORD[ebp - 4]
                        jmp loop
        loopend:

        mov esp, ebp
        pop ebp
        ret

printnumber:
        push ebp
        mov ebp, esp

        sub esp, 8
        ; counter 10 digits in a dword
        mov DWORD[ebp - 4], 0
        ; counter to remote zeros
        mov DWORD[ebp - 8], 0

        loop2:
        cmp DWORD[ebp - 4], 10
        je loop2end
        mov eax, DWORD[ebp + 8]
        cdq
        mov ecx, 10
        idiv ecx

        cmp edx, 0
        je zeroadd
                inc DWORD[ebp - 8]
        zeroadd:

        cmp DWORD[ebp - 8], 0
        je loop2

        mov DWORD[ebp + 8], eax
        add edx, 0x30
        push edx
        inc DWORD[ebp - 4]
        jmp loop2

        loop2end:
        mov DWORD[ebp - 4], 0

        loop3:
        cmp DWORD[ebp - 4], 10
        je loop3end
        pop eax
        inc DWORD[ebp - 4]
        mov edx, DWORD[ebp - 4]
        cmp DWORD[ebp - 8], edx
        jge loop3

        push eax
        call printchar
        add esp, 4
        jmp loop3
        loop3end:


        mov esp, ebp
        pop ebp
        ret

printchar:
        push ebp
        mov ebp, esp

        mov eax, 4
        mov ebx, 1
        mov edx, 1
        lea ecx, [ebp + 8]
        int 0x80

        mov esp, ebp
        pop ebp
        ret

printstring:
        push ebp
        mov ebp, esp

        mov edx, 0

        mov esi, DWORD[ebp + 8]
        toploop:
        cmp BYTE[esi + edx], 0
        je endloop
                inc edx
        jmp toploop
        endloop:

        mov eax, 4
        mov ebx, 1
        mov ecx, DWORD[ebp+8]
        int 0x80

        mov esp, ebp
        pop ebp
