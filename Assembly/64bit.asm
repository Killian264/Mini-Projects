segment .data

        fmt_scanf db "%d",0
        fmt_printf db "%s",0
        fmt_printf_int db "%d",10,0
        largest db "Largest: ",0
        smallest db "Smallest: ",0
        sum db "Sum: ",0

segment .bss

        arr resd 10

segment .text
        global  main
        extern scanf
        extern printf

main:
        push    rbp
        mov             rbp, rsp
        ; ********** CODE STARTS HERE **********

        ; smallest
        mov r14, 999999999
        ; biggest
        mov r13, 0
        ; sum
        mov r12, 0

        mov     r15, 0
        top_read_loop:
        cmp r15, 10
        jge end_read_loop

                mov rdi, fmt_scanf
                lea rsi, [arr + r15 * 4]
                call scanf

        mov esi, DWORD[arr + r15 * 4]
        add r12, rsi

        ; if statements

        cmp rsi, r14
        jge smallend
        mov r14, rsi
        smallend:

        cmp rsi, r13
        jle largeend
        mov r13, rsi
        largeend:

        add r15, 1
        jmp top_read_loop
        end_read_loop:


        ; each of these load in the string that i want then print  the number after it
        mov rdi, fmt_printf
        mov rsi, largest
        call printf

        mov rdi, fmt_printf_int
        mov rsi, r13
        call printf

        mov rdi, fmt_printf
        mov rsi, smallest
        call printf

        mov rdi, fmt_printf_int
        mov rsi, r14
        call printf

        mov rdi, fmt_printf
        mov rsi, sum
        call printf

        mov rdi, fmt_printf_int
        mov rsi, r12
        call printf


        ; *********** CODE ENDS HERE ***********
        mov             rax, 0
        mov             rsp, rbp
        pop             rbp
        ret
