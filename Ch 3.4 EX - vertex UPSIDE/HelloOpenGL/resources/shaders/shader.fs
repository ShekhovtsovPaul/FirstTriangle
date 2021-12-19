#version 330 core
out vec4 FragColor;

in vec3 ourColor;
uniform float xOffset;

void main()
{
    FragColor = vec4(ourColor.x + xOffset, ourColor.y + xOffset + 0.5f, ourColor.z + xOffset + 1.0f, 1.0f);
}
