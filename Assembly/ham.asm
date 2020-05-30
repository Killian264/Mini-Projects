%include "/usr/local/share/csc314/asm_io.inc"


segment .data

        format  db      "Hamming distance = %d",10,0

        ; the hamming distance between these is 1
        str1    db      "testa",0
        str2    db      "cxctb",0

segment .bss


segment .text
        global  asm_main
        extern  printf

asm_main:
        enter   0,0
        pusha
        ;***************CODE STARTS HERE***************************

        ; call your ham dist function here
        ; pass str1 and str2 as arguments
        ; result gets returned in EAX
        push str2
        push str1
        call hamdist
        add esp, 8

        push    eax             ; the returned integer from hamdist()
        push    format  ; "Hamming distance = %d\n"
        call    printf
        add             esp, 8

        ;***************CODE ENDS HERE*****************************
        popa
        mov     eax, 0
        leave
        ret

hamdist:
        push ebp
        mov ebp, esp
        sub esp, 8

        mov DWORD[ebp - 4], 0
        mov DWORD[ebp - 8], 0

        loop:
                                mov ebx, DWORD[ebp - 4]
                cmp BYTE [ebp + 12 + ebx], 0
                je loopend
                                mov eax, DWORD [ebp + 12]
                mov cl, BYTE[eax + ebx]
                                mov eax, DWORD [ebp + 8]
                cmp cl, BYTE[eax + ebx]
                je ifend
                        inc DWORD[ebp - 8]
                ifend:
                inc DWORD[ebp - 4]
                jmp loop
        loopend:

        mov eax, DWORD[ebp - 8]
        mov esp, ebp
        pop ebp
