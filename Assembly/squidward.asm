%include "/usr/local/share/csc314/asm_io.inc"


segment .data
        msg_code db "Krabby Patty code is: ",0
        msg_lettuce db "Lettuce?: ",0
        msg_onions  db "Onions?: ",0
        msg_tomatoes db "Tomatoes?: ",0
        msg_pickles db "Pickles?: ",0
        msg_mustard db "Mustard?: ",0
        msg_ketchup db "Ketchup?: ",0

segment .bss


segment .text
        global  asm_main

asm_main:
        push    ebp
        mov             ebp, esp
        ; ********** CODE STARTS HERE **********

        mov ecx, 0

        mov eax, msg_lettuce
        call print_string
        call read_char
        cmp al, 'n'
        je nolettuce
        add ecx, 1
        nolettuce:

        call read_char
        mov eax, msg_onions
        call print_string
        call read_char
        cmp al, 'n'
        je noonions
        add ecx, 2
        noonions:

        call read_char
        mov eax, msg_tomatoes
        call print_string
        call read_char
        cmp al, 'n'
        je notomatoes
        add ecx, 4
        notomatoes:

        call read_char
        mov eax, msg_pickles
        call print_string
        call read_char
        cmp al, 'n'
        je nopickles
        add ecx, 8
        nopickles:

        call read_char
        mov eax, msg_mustard
        call print_string
        call read_char
        cmp al, 'n'
        je nomustard
        add ecx, 16
        nomustard:

        call read_char
        mov eax, msg_ketchup
        call print_string
        call read_char
        cmp al, 'n'
        je noketchup
        add ecx, 32
        noketchup:

        mov eax, msg_code
        call print_string
        xor ecx, 123123
        mov eax, ecx
        call print_int
                call print_nl
        ; *********** CODE ENDS HERE ***********
        mov             eax, 0
        mov             esp, ebp
        pop             ebp
        ret
