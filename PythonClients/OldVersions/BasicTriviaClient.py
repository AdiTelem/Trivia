import socket

SERVER_ADDRESS = '127.0.0.1'
SERVER_PORT = 6969
QUIT_MESSAGE = "EXITA"

def get_and_print(sock):
    """
    This function gets a socket waiting for answer for the server and printing it
    :param sock: get socket
    :return: none
    """
    try:
        answer = sock.recv(4096).decode('utf-8')
        print(answer)
    except Exception as e:
        print("Error: ", e)
        quit()


def talk_with_server(sock):
    """
    This function talks with the server
    :param sock: socket
    :return: none
    """
    try:
        sock.connect((SERVER_ADDRESS, SERVER_PORT))
    except Exception as e:
        print("Error: ", e)
        return "Error"
    msg = ""
    get_and_print(sock)
    while msg != QUIT_MESSAGE:
        msg = input("Enter what do you want to sent:\n")
        try:
            sock.send(msg.encode('utf-8'))
        except Exception as e:
            print("Error: ", e)
            break


def main():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
        talk_with_server(sock)


if __name__ == '__main__':
    main()
