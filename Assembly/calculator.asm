%include "/usr/local/share/csc314/asm_io.inc"


segment .data


segment .bss


segment .text
        global  asm_main

asm_main:
        push    ebp
        mov             ebp, esp
        ; ********** CODE STARTS HERE **********

        ; A=EDI, CHAR=EBX, B=EDX

        call read_int
        mov edi, eax
        ; to negate the new line char I have two one to take that input and another to take the actual char
        call read_char
        call read_char
        ; move al to bl because eax will be overwitten
        mov bl, al
        call read_int
        mov edx, eax
        mov al, bl
        ; I could have had all the code here and had a jne but its easier to organize this way
        cmp al, '+'
        je add
        cmp al, '-'
        je sub
        cmp al, '*'
        je mul
        cmp al, '/'
        je div
        cmp al, '%'
        je mod
        cmp al, '^'
        je exp

        add:
        add edi, edx
        jmp print
        sub:
        sub edi, edx
        jmp print
        mul:
        ; simple mul function moving edx to eax to allow eax * edi then moving eax to edi for output
        mov eax, edx
        imul edi
        mov edi, eax
        jmp print
        div:
        ; I have to move both edi and edx here because div uses edx
        mov eax, edi
        mov ecx, edx
        ; cdq spans out the number between the two registers
        cdq
        idiv ecx
        ; i move in eax because this is div not mod
        mov edi, eax
        jmp print
        mod:
        ; same as div but I move in edx as that holds the remainder
        mov eax, edi
        mov ecx, edx
        cdq
        idiv ecx
        mov edi, edx
        jmp print
        exp:
        ; If the power is 0 it needs to return 1 and if its 1 it doesnt need to run
        cmp edx, 0
        jne next
        mov edi, 1
        jmp print
        next:
        cmp edx, 1
        je print
        ; moving edi to eax for mul and moving edx to ecx because mul uses edx:eax when outputting
        mov eax, edi
        mov ecx, edx
        ; this loop multiplies then subtracts 1 from from the counter then compares the counter to 1 to decide
        ; if it needs to continue multiplying
        loop_start:
        imul edi
        sub ecx, 1
        cmp ecx, 1
        jnz loop_start
        mov edi, eax
        print:
        ; here I move = to al for the print then move edi to eax for the print
        mov al, '='
        call print_char
        mov eax, edi
        call print_nl
        call print_int
        call print_nl

        ; *********** CODE ENDS HERE ***********
        mov             eax, 0
        mov             esp, ebp
        pop             ebp
        ret
