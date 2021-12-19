#version 330 core
out vec4 FragColor;

in vec3 ourColor;
uniform float xOffset;

void main()
{
    FragColor = vec4(ourColor + xOffset, 1.0f);
}
