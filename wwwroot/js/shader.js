
// basic example is ai generated, with shader code from shadertoy.com
// based code from here: https://www.shadertoy.com/view/7tVyWc 

window.initShader = (canvasId) => {
    const canvas = document.getElementById(canvasId);
    if (!canvas) return;

    const gl = canvas.getContext('webgl2') || canvas.getContext('webgl');
    if (!gl) return;

    const vsSource = `#version 300 es
        in vec4 position;
        void main() { gl_Position = position; }
    `;
    
   const fsSource = `#version 300 es
        precision mediump float;
        uniform float iTime;
        uniform vec2 iResolution;
        
        float DistLine(vec2 p, vec2 a, vec2 b){
            vec2 pa = p-a;
            vec2 ba = b-a;
            float t = clamp(dot(pa, ba) / dot(ba, ba), 0., 1.);
            return length(pa -ba *t);
        }
        
        float Line(vec2 p, vec2 a, vec2 b){
            float d = DistLine(p,a,b);
            if (d>.02) return 0.;
            float d2= length(a-b);
            float m = smoothstep(.02, .001, d);
            m *= smoothstep(1.2, .001, length(a-b)) *.5 + smoothstep(.1, .03, abs(d2-.75));
             return m;
        }
        
        float N21(vec2 p){
            p = fract(p*vec2(233.213, 853.23));
            p += dot(p, p+23.24);
            return fract(p.x*p.y);
        }
       
        vec2 N22(vec2 p){
            vec3 p3 = fract(vec3(p,1)*vec3(233.213, 853.23, 233.213));
            p3 += dot(p3, p3.yzx + 23.24);
            return fract(vec2(p3.x*p3.y, p3.y*p3.z));
        }
        
        vec2 GetPos(vec2 id, vec2 off){
            vec2 n = N22(id + off) * iTime;
            return off + sin(n) *.4;
        }
        
        float Layer(vec2 uv){
            vec2 gv = fract(uv) -.5;
            vec2 id = floor(uv);
            float m = 0.;
        
            vec2 p[9];
            int i = 0;
            
            for(float y=-1.;y<=1.;y++){
                for(float x=-1.;x<=1.;x++){
                    p[i++] = GetPos(id, vec2(x, y));
                }
            }
            
            float t=iTime* 5.;
            
            
            for(int i = 0; i < 9;i++)
            {
                m += Line(gv, p[4], p[i]);
                
                vec2 j = (p[i] - gv) *30.;
                float sparkle =  1./dot(j, j);
                
                m+= sparkle*(sin(t+fract(p[i].x)*10.)*.5 + .5);
            }
            
             m += Line(gv, p[1], p[3]);
             m += Line(gv, p[1], p[5]);
             m += Line(gv, p[3], p[7]);
             m += Line(gv, p[5], p[7]);
             
             return m;
        }
        
        out vec4 fragColor;
        
        void main() {
            vec2 uv = (gl_FragCoord.xy - .5 * iResolution.xy )/iResolution.y;
            uv *= 2.;
            
            float m = 0.;
            float t = iTime * .07;
            
            for(float i=0.;i<1.;i+= 1./3.){
                float z = fract(i+t);
                float size = mix(10., .5, z);
                float fade = smoothstep(0., .9, z) * smoothstep(1., .8, z);
                m += Layer(uv * size + i*24. ) * fade;
            }
            fragColor = vec4(vec3(m, m, .7*m),0.01);
        }  
   `; 

    const createShader = (type, source) => {
        const s = gl.createShader(type);
        gl.shaderSource(s, source);
        gl.compileShader(s);
        if (!gl.getShaderParameter(s, gl.COMPILE_STATUS)) {
            console.error("Shader Error:", gl.getShaderInfoLog(s));
            gl.deleteShader(s);
            return null;
        }
        return s;
    };

    const program = gl.createProgram();
    const vs = createShader(gl.VERTEX_SHADER, vsSource);
    const fs = createShader(gl.FRAGMENT_SHADER, fsSource);

    if (!vs || !fs) return;

    gl.attachShader(program, vs);
    gl.attachShader(program, fs);
    gl.linkProgram(program);

    if (!gl.getProgramParameter(program, gl.LINK_STATUS)) {
        console.error("Linker Error:", gl.getProgramInfoLog(program));
        return;
    }
    gl.useProgram(program);

    const buffer = gl.createBuffer();
    gl.bindBuffer(gl.ARRAY_BUFFER, buffer);
    gl.bufferData(gl.ARRAY_BUFFER, new Float32Array([-1, -1, 3, -1, -1, 3]), gl.STATIC_DRAW);

    const pos = gl.getAttribLocation(program, "position");
    gl.enableVertexAttribArray(pos);
    gl.vertexAttribPointer(pos, 2, gl.FLOAT, false, 0, 0);

    const iTimeLoc = gl.getUniformLocation(program, "iTime");
    const iResLoc = gl.getUniformLocation(program, "iResolution");

    const resize = () => {
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
        gl.viewport(0, 0, canvas.width, canvas.height);
    };
    window.addEventListener('resize', resize);
    resize();

    function render(time) {
        if (!gl || gl.isContextLost()) return;

        gl.clearColor(0, 0, 0, 1);
        gl.clear(gl.COLOR_BUFFER_BIT);

        gl.useProgram(program);
        gl.uniform1f(iTimeLoc, time * 0.001);
        gl.uniform2f(iResLoc, canvas.width, canvas.height);
        gl.drawArrays(gl.TRIANGLES, 0, 3);

        requestAnimationFrame(render);
    }
    requestAnimationFrame(render);
};