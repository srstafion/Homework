#include <SFML/Graphics.hpp>

int main()
{
    sf::RenderWindow window1(sf::VideoMode(512, 512), "Window 1");
    window1.setPosition(sf::Vector2i(0, 0));

    sf::RenderWindow window2(sf::VideoMode(512, 512), "Window 2");
    window2.setPosition(sf::Vector2i(window1.getPosition().x + window1.getSize().x, 0));

    sf::Texture texture;
    texture.loadFromFile("checkboard.png");

    sf::Sprite sprite(texture);
    sprite.setPosition(100.f, 100.f);

    sf::Vector2f point1(100.f, 100.f);
    sf::Vector2f point2(300.f, 100.f);
    sf::Vector2f point3(300.f, 300.f);
    sf::Vector2f point4(100.f, 300.f);

    sf::VertexArray lines(sf::LinesStrip, 5);
    lines[0].position = point1;
    lines[1].position = point2;
    lines[2].position = point3;
    lines[3].position = point4;
    lines[4].position = point1;

    for (int i = 0; i < lines.getVertexCount(); ++i) {
        lines[i].color = sf::Color::Red;
    }

    while (window1.isOpen() || window2.isOpen())
    {
        sf::Event event;
        while (window1.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window1.close();
        }

        while (window2.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window2.close();
        }

        window1.clear();
        window1.draw(sprite);
        window1.draw(lines);

        // Draw circles at each point with specified colors
        sf::CircleShape point1Circle(5);
        point1Circle.setFillColor(sf::Color::Blue);
        point1Circle.setPosition(point1.x - 5, point1.y - 5);
        window1.draw(point1Circle);

        sf::CircleShape point2Circle(5);
        point2Circle.setFillColor(sf::Color::Green);
        point2Circle.setPosition(point2.x - 5, point2.y - 5);
        window1.draw(point2Circle);

        sf::CircleShape point3Circle(5);
        point3Circle.setFillColor(sf::Color::Magenta);
        point3Circle.setPosition(point3.x - 5, point3.y - 5);
        window1.draw(point3Circle);

        sf::CircleShape point4Circle(5);
        point4Circle.setFillColor(sf::Color::Cyan);
        point4Circle.setPosition(point4.x - 5, point4.y - 5);
        window1.draw(point4Circle);

        window1.display();

        if (sf::Keyboard::isKeyPressed(sf::Keyboard::W)) {
            sprite.move(0, 1);
        }
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::S)) {
            sprite.move(0, -1);
        }
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::A)) {
            sprite.move(1, 0);
        }
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::D)) {
            sprite.move(-1, 0);
        }

        window2.clear(sf::Color(173, 216, 230)); // Light blue color
        sf::RenderTexture renderTexture;
        renderTexture.create(200, 200);
        renderTexture.clear();
        renderTexture.draw(sprite, sf::RenderStates(sf::Transform().translate(-100.f, -100.f)));
        renderTexture.display();
        sf::Sprite spriteInsideRedSquare(renderTexture.getTexture());
        spriteInsideRedSquare.setPosition(0, window1.getSize().y / 2);
        spriteInsideRedSquare.scale(2.56, 1.28);
        window2.draw(spriteInsideRedSquare);
        window2.display();
    }
}
