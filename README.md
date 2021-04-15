ndig
======

dig like simple CLI DNS Lookup tool, implemented with .NET Core

## Installation

```shell
scoop install https://raw.githubusercontent.com/guneysus/ndig/master/ndig.json
```

## Usage

Currently only `A`, `CNAME`, `TXT` and `MX` records supported.


### Querying `A` records

```shell
>  ndig -d google.com -t A

Showing A records for google.com
172.217.169.174
```

### Querying `TXT` records

```shell
> ndig -d google.com -t TXT

Showing TXT records for google.com
v=spf1 include:_spf.google.com ~all
facebook-domain-verification=22rm551cu4k0ab0bxsw536tlds4h95
docusign=05958488-4752-4ef2-95eb-aa7ba8a3bd0e
docusign=1b0a6754-49b1-4db5-8540-d2c12664b289
globalsign-smime-dv=CDYX+XFHUw2wml6/Gb8+59BsH31KzUr6c1l2BPvqKX8=
```

### Querying `CNAME` records

```shell
> ndig -d blog.guneysu.xyz -t CNAME

Showing CNAME records for blog.guneysu.xyz
blog.guneysu.xyz.s3-website.eu-central-1.amazonaws.com
```

### Formatting the output

Now only plain output implemented. JSON and CSV formatting would be implemented if required.

## Why the executable is so big: (~ 35MB)?

This is tool developed with .NET Core 3.1.
Since the runtime included in as a consequence the executable became so big.
Without the runtime, it is under `1MB`.


## Why?

This tool born spontaneously while learning the Windows APIs with .NET.
Then converted to CLI tool and implemented a simple scoop application manifest to distribute.

## Is It Cross Platform?

NO and should not be. Who needs this tool while `dig` tool exists on linux repositories?


