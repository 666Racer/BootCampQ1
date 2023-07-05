from flask import Flask


app = Flask(__name__)


@app.route('/') #декоратор, взывает функцию
def main(): #функция: между ней и декоратором ничего не должно быть
        return "<h1>Hello world</h1><br><a href='/index'>перейти на 2-ю страницу</a>"
        #br - одиночный тег, а - гиперссылка
@app.route('/index/<x>/<y>') #x и y - значения, указываются в URL через "/"
def index(x, y): #функция: между ней и декоратором ничего не должно быть
        return f'Результат: {int(x) + int(y)}' #f - функция, интерполяция строк

if __name__ == '__main__':
        app.run()

#С Python лучше работать в PyCharm, чем в VSC - но там пробник на 30 дней