import socket


SERVER_ADDRESS = '127.0.0.1'
SERVER_PORT = 6969
QUIT_MESSAGE = "EXITA"
LOGIN_CODE = 10
SIGNUP_CODE = 11
USERNAME_KEY = "username"
PASSWORD_KEY = "password"
EMAIL_KEY = "email"


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


def send_message(sock, msg, encoded=True):
    try:
        if encoded:
            sock.send(msg.encode('utf-8'))
        else:
            sock.send(msg)
    except Exception as e:
        print("Error: ", e)


def turn_into_json(keys, values):
    json_dict = {keys[i]: values[i] for i in range(len(keys))}
    return str(json_dict)


def login(sock, username, password):
    json = turn_into_json([USERNAME_KEY, PASSWORD_KEY], [username, password])
    code = LOGIN_CODE
    length = len(json)
    msg = code.to_bytes(1, 'big') + length.to_bytes(4, 'little') + json.encode()
    print(json)
    send_message(sock, msg, False)


def signup(sock, username, password, email):
    json = turn_into_json([USERNAME_KEY, PASSWORD_KEY, EMAIL_KEY], [username, password, email])
    code = SIGNUP_CODE
    length = len(json)
    msg = code.to_bytes(1, 'big') + length.to_bytes(4, 'little') + json.encode()
    print(json)
    send_message(sock, msg, False)


def exit_connection():
    exit()


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
    while msg != QUIT_MESSAGE:
        username = input("Enter your username: ")
        password = input("Enter your password: ")
        option = input("Enter what do u want to do?\n").lower()
        if option == "login":
            login(sock, username, password)
        elif option == "signup":
            email = input("Enter your email")
            signup(sock, username, password, email)
        elif option == "exit":
            exit_connection()
        get_and_print(sock)


def main():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
        talk_with_server(sock)


if __name__ == '__main__':
    main()
