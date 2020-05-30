%include "/usr/local/share/csc314/asm_io.inc"


segment .data


segment .bss

        intarr resd 10

segment .text
        global  asm_main

asm_main:
        push    ebp
        mov             ebp, esp
        ; ********** CODE STARTS HERE **********

        mov ecx, 0

        toploop:
                call read_int
                mov DWORD [intarr + ecx * 4], eax
                inc ecx
        cmp ecx, 10
        jl toploop
        mov ecx, 0
        mov ebx, 0

        loop1:
                mov ebx, 0
                loop2:
                        mov eax, [intarr + ebx * 4]
                        cmp eax, DWORD [intarr + ebx * 4 + 4]
                        jge ifend
                                mov edx, [intarr + ebx * 4 + 4]
                                mov [intarr + ebx * 4], edx
                                mov [intarr + ebx * 4 + 4], eax
                        ifend:
                        inc ebx
                        mov eax, 10
                        sub eax, ecx
                        dec eax
                        cmp ebx, eax
                        jl loop2
                inc ecx
                cmp ecx, 10 - 1
                jl loop1

        call print_nl
        mov ecx, 0
        printloop:
                mov eax, DWORD [intarr + ecx * 4]
                call print_int
                call print_nl
                inc ecx
        cmp ecx, 10
        jl printloop

        ; *********** CODE ENDS HERE ***********
        mov             eax, 0
        mov             esp, ebp
        pop             ebp
        ret
